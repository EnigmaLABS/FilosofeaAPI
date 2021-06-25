namespace FilosofeaDomain.ServiceInterfaces
{
    public interface IUserService
    {
        void GetUserById();
        void GetUserByUserName(string username);
    }
}