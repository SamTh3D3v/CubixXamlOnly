using System.Threading.Tasks;

namespace CubixXaml.Model
{
    public class DataService : IDataService
    {
        public async Task<DataItem> GetData()
        {
            // Use this to connect to the actual data service

            // Simulate by returning a DataItem
            var item = new DataItem("Welcome to MVVM Light");
            return item;
        }
    }
}