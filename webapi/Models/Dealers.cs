// Base Class Dealer
namespace webapi.Models;

public class Dealers
{
    private readonly string _status;
    
    public IEnumerable<Cars> Cars { get; set; }

    public Dealers(string status)
    {
        _status = status;
    }

    public void Load(IEnumerable<Data.Cars> cars)
    {
        Cars = cars
            .Select(c => new Cars(c, _status));
    }

}
