namespace webapi.Data
{
    public class DbContext
    {
        public DbContext() { }

        public async Task<IEnumerable<Cars>> GetCars(int count, string search, string sort)
        {
            IEnumerable<int> items = await genetateList(count);
            string[] americanModels = new[] { "GM", "Ford", "Chrysler", "Dodge", "Jeep", "Buick", "RAM", "Cadillac", "Lincoln" };
            string[] colors = new[] { "Red", "White", "Pink", "Black", "Gray", "Blue" };

            IEnumerable<Cars> results = items.Select(item =>
                new Cars()
                {
                    Price = Random.Shared.Next(2000, 55000),
                    Model = americanModels[Random.Shared.Next(americanModels.Length)],
                    Mileage = Random.Shared.Next(20, 550),
                    Color = colors[Random.Shared.Next(colors.Length)],
                    Active = (item % 2) == 1
                }
            );

            if (!string.IsNullOrEmpty(search))
            {
                results = results
                        .Where(o => o.Model.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (string.IsNullOrEmpty(sort))
                return results;
            if (sort.Equals("model", StringComparison.OrdinalIgnoreCase))
            {
                return results
                    .OrderBy(o => o.Model)
                    .ThenBy(o => o.Price);
            }

            if (sort.Equals("price", StringComparison.OrdinalIgnoreCase))
            {
                return results
                     .OrderBy(o => o.Price);
            }
            return results;
        }


        async Task<IEnumerable<int>> genetateList(int count)
        {
            return await Task.FromResult(Enumerable.Range(1, count));
        }
    }
}
