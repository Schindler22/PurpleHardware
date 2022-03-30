namespace PurpleHardware;
    public interface IUserClientService
    {
        Task<List<UserClient>> GetUserClients();
        void NewUserClients(UserClient userClient);
        void DeleteUserClients(int id);
        Task<string> UpdateUserClients(UserClient userClient);
    }