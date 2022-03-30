using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PurpleHardware;

public class UserClientRepository : IUserClientRepository
{
    private readonly UserContext _context;
    public UserClientRepository(UserContext context)
    {
        _context = context;
    }
    public void DeleteUserClient(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserClient>> GetUserClients()
    {
        var result = await _context.UserClients.ToListAsync();
        
        if(result == null){
            return new List<UserClient>();
        } else{
            return result;
        }
    }

    public UserClient GetUserClient(int id)
    {
        throw new NotImplementedException();
    }

    public void NewUserClient(UserClient userClient)
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateUserClient(UserClient userClient, int id)
    {
        throw new NotImplementedException();
    }
}