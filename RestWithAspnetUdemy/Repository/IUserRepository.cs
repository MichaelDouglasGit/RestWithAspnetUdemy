using RestWithAspnetUdemy.Data.VO;
using RestWithAspnetUdemy.Model;

namespace RestWithAspnetUdemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
