using System.Threading.Tasks;

namespace CubixXaml.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}