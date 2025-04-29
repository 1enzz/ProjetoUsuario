using ProjetoUsuarios.Models;

namespace ProjetoUsuarios.Repositories
{
    public class UserRepository
    {
        private static List<User> _users = new List<User>();

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Update(User user) 
        { 
            var existingUser = GetById(user.Id);
            if (existingUser == null)
            {
                return;
            }
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;


        }

        public void Delete(int id) 
        { 
            var user = GetById(id);
            if (user != null) {
                _users.Remove(user);
            }
        }
    }
}
