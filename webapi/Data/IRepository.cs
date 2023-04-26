namespace webapi.Data
{
    public interface IRepository
    {
        Task<IEnumerable<Cars>> GetCars(int count, string search, string sort);
    }
}
