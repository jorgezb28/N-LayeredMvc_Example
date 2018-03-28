using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.Dto;

namespace AppService.IAppService
{
    public interface IStoreAppService
    {
        StoreDto CreateNewStore(StoreDto newStore);
        IEnumerable<StoreDto> GetAllStores();
        StoreDto UpdateDto(StoreDto storeToUpadte);
        void Remove(StoreDto storeDto);
        StoreDto GetStoreById(int storeId);
    }
}
