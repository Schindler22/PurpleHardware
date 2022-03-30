namespace PurpleHardware;
    public interface IUserClientRepository
    {
        Task<List<UserClient>> GetUserClients();
        void NewUserClient(UserClient userClient);
        void DeleteUserClient(int id);
        Task<string> UpdateUserClient(UserClient userClient, int id);
        UserClient GetUserClient(int id);
    }