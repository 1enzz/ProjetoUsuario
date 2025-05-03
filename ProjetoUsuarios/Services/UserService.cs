using ProjetoUsuarios.Models;
using ProjetoUsuarios.Repositories;
using System.Runtime.InteropServices;

namespace ProjetoUsuarios.Services
{
    public class UserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAll();
        }

        public User GetUserById(int id) { 
            return _repository.GetById(id);
        }

        public bool CreateUser(User user)
        {

            var usuarioExistente = GetUserById(user.Id);

            if (usuarioExistente == null)
            {
                 
                _repository.Add(user);
                return true;
            }
            else
            {
             
                return false;
            }


        }
        public void UpdateUser(User user) {
            _repository.Update(user);
        }
        public void DeleteUser(int id) {
            _repository.Delete(id);
        }

    }
}
