using Models;
using System.Threading.Tasks;

namespace ApplicationLogic.Interfaces
{
    public interface ITypeService
    {
        public Task<bool> IsMultiplyAsync(ComponentType componentType);
    }
}
