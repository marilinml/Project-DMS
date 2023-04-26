// Service for Dealers
using webapi.Data;
using webapi.Models;

namespace webapi.Services
{
    public class Services
    {
        private IRepository _repository;

        public Services(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Models.Cars>> GetDealerCars(int dealerId, int count, string search, string order)
        {
            var cars = await _repository.GetCars(count, search, order);

            switch (dealerId)
            {
                case 2:
                    var dealer2 = new Dealer2();
                    dealer2.Load(cars);
                    return dealer2.Cars;
                default:
                    var dealer = new Dealer1();
                    dealer.Load(cars);
                    return dealer.Cars;
            }
        }
    }
}
