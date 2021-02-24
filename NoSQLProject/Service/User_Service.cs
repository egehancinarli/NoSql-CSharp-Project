using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace Service
{
    public class User_Service
    {
        User_DAO userDAO = new User_DAO();

        public void AddUser(User user)
        {
            userDAO.AddUser(user);
        }
        public bool IsUsernamePresent(string username)
        {
            return userDAO.IsUsernamePresent(username);
        }
        public bool IsEmailPresent(string email)
        {
            return userDAO.IsEmailPresent(email);
        }
        public List<User> getAllUsers()
        {
            return userDAO.GetAllUsers();
        }
        public void UpdateUserTickets(User newUser)
        {
            userDAO.UpdateUserTickets(newUser);
        }
        public User GetUserById(int id)
        {
            return userDAO.GetUserById(id);
        }
        public User GetUserByName(string username)
        {
            return userDAO.GetUserByName(username);
        }
        public User GetUserByFullName(string firstname, string lastname)
        {
            return userDAO.GetUserByFullName(firstname, lastname);
        }
        public User GetUserByEmail(string email)
        {
            return userDAO.GetUserByEmail(email);
        }
        public void UpdateUserPassword(User user,string password)
        {
            userDAO.UpdateUserPassword(user, password);
        }
    }
}
