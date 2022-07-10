using System.Threading.Tasks;

namespace StoreApi.Services
{
    public interface ICar
    {
        public Task<Car> getCar(int id);
        public Task<Car> addCar(Car user);
        public Task<bool> editCar(Car user);
        public Task<bool> deleteCar(int id);
    }
}
