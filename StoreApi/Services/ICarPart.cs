using StoreApi.Models;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public interface ICarPart
    {
        public Task<CarPart> getCarPart(int id);
        public Task<CarPart> addCarPart(CarPart user);
        public Task<bool> editCarPart(CarPart user);
        public Task<bool> deleteCarPart(int id);
    }
}
