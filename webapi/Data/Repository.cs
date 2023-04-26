namespace webapi.Data
{
    public class Repository : IRepository
    {
        private DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Cars>> GetCars(int count, string search, string sort)
        {
            IEnumerable<Cars> cars = await _dbContext.GetCars(count, search, sort);

            return cars;
        }
    }
}
