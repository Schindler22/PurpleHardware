namespace PurpleHardware;
    public class UserClientService: IUserClientService
    {
    private readonly IUserClientRepository _repository;
    
    public UserClientService(IUserClientRepository repository)
    {
        _repository = repository;
    }

    public void DeleteUserClients(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserClient>> GetUserClients()
    {
        throw new NotImplementedException();
    }

    public void NewUserClients(UserClient userClient)
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateUserClients(UserClient userClient)
    {
        throw new NotImplementedException();
    }
}
