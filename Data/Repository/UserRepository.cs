using Data.Context;
using Data.Model;
using Data.Utils;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public override void Create(User model)
        {
            model.Password = Cryptography.Cryptograph(model.Password);
            base.Create(model);

        }

        public User Login(string email, string password)
        {
            password = Cryptography.Cryptograph(password);
            User user = new User();
            using (WarrContext warrContext = new WarrContext())
            {
                user = warrContext.User.Where(user => user.Email == email && user.Password == password).FirstOrDefault();
            }
            return user;
        }
    }
}
