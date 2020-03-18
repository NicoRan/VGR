using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Services.Contracts
{
    public interface IPowerUserService
    {
        Task<PowerUser> CreateUserAsync(string email);
        Task<PowerUser> FindUserAsync(string email);
    }
}