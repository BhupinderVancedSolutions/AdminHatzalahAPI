using Application.Abstraction.SignalR;
using Microsoft.AspNet.SignalR;
namespace Infrastructure.Implementation.Hub
{
    public class LogoutUsersHub : Hub<IHubClient>
    {
    }
}
