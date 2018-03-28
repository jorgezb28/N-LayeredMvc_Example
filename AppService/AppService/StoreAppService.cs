using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AppService.Dto;
using AppService.IAppService;
using AutoMapper;
using Domain.Entities;
using Domain.Generic;
using Infraestructure;

namespace AppService.AppService
{
    public class StoreAppService:IStoreAppService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StoreAppService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public StoreDto CreateNewStore(StoreDto newStore)
        {
            var storeDb = Mapper.Map<StoreDto, Store>(newStore);
            _unitOfWork.StoreRepository.Add(storeDb);
            _unitOfWork.Commit();
            newStore = Mapper.Map<Store, StoreDto>(storeDb);
            return newStore;
        }

        public IEnumerable<StoreDto> GetAllStores()
        {
            var allStoresDb = _unitOfWork.StoreRepository.GetAll();
            var allStoresDto = Mapper.Map<IEnumerable<Store>, IEnumerable<StoreDto>>(allStoresDb);
            return allStoresDto;
        }

        public StoreDto UpdateDto(StoreDto storeToUpadte)
        {
            var store = _unitOfWork.StoreRepository.GetSingle(s => s.StoreId == storeToUpadte.StoreId);
            store.Name = storeToUpadte.Name;
            store.Phone = storeToUpadte.Phone;
            _unitOfWork.Commit();

            storeToUpadte = Mapper.Map<Store, StoreDto>(store);
            return storeToUpadte;
        }

        public void Remove(StoreDto storeDto)
        {
            var storeDb = Mapper.Map<StoreDto, Store>(storeDto);
            _unitOfWork.StoreRepository.Remove(storeDb);
            _unitOfWork.Commit();
        }

        public StoreDto GetStoreById(int storeId)
        {
            var storeDb = _unitOfWork.StoreRepository.GetSingle(s => s.StoreId == storeId);
            var storeDto = Mapper.Map<Store, StoreDto>(storeDb);
            return storeDto;
        }
    }
}
