using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using Model;
using MongoDB.Driver;

namespace DAO
{
    public class User_DAO : Base
    {
        public void AddUser(User user)
        {
            CreateDocument("users", CreateUserDocument(user));

        }

        //written by Egehan Cinarli: gets all the users from the database as a Bson Document and converts it into a List of user objects.
        public List<User> GetAllUsers()
        {
            List<BsonDocument> docs = ReadDocuments("users");
            List<User> allUsers = new List<User>();

            foreach (BsonDocument doc in docs)
            {
                User user = new User
                {
                    username = (string)doc["username"],
                    password = (string)doc["password"],
                    firstName = (string)doc["firstName"],
                    lastName = (string)doc["lastName"],
                    email = (string)doc["email"],
                    nrTickets = doc["tickets"].AsInt32,
                    id = doc["user_id"].AsInt32
                };
                allUsers.Add(user);
            }

            return allUsers;
        }

        //Written by Egehan Cinarli: checks if the username is present in the users collection.
        public bool IsUsernamePresent(string username)
        {
            
            List<BsonDocument> users = ReadDocuments("users");

            foreach (BsonDocument doc in users)
            {
                if (doc["username"].AsString.Equals(username))
                    return true;
            }

            return false;
        }
        public bool IsEmailPresent(string email)
        {

            List<BsonDocument> users = ReadDocuments("users");

            foreach (BsonDocument doc in users)
            {
                if (doc["email"].AsString.ToLower().Equals(email.ToLower()))
                    return true;
            }

            return false;
        }
        public User GetUserByName(string username)
        {           
            List<User> users = GetAllUsers();
            foreach (User user in users)
            {
                if(user.username == username)
                {
                    return user;                 
                }
                    
            }
            return null;
        }
        public User GetUserByFullName(string firstname, string lastname)
        {
            List<User> users = GetAllUsers();
            foreach (User user in users)
            {
                if (user.firstName == firstname && user.lastName == lastname)
                {
                    return user;
                }

            }
            return null;
        }
        public User GetUserByEmail(string email)
        {
            List<User> users = GetAllUsers();
            foreach (User user in users)
            {
                if (user.email == email)
                {
                    return user;
                }

            }
            return null;
        }
        private BsonDocument CreateUserDocument(User user)
        {
            return new BsonDocument
            {
                { "user_id", GetLatestId("users","user_id") },
                { "username", user.username },
                {"password",user.password },
                {"firstName", user.firstName },
                {"lastName",user.lastName },
                {"email",user.email },
                {"tickets",user.nrTickets }
            };
        }
        //Written by Cosmin Ilie: returns a user based on the given ID
        public User GetUserById(int id)
        {
            var userDoc = ReadDocument("users", "user_id", id);
            if(userDoc != null)
                return new User
                {
                    id = (int)userDoc["user_id"],
                    username = (string)userDoc["username"],
                    password = (string)userDoc["password"],
                    firstName = (string)userDoc["firstName"],
                    lastName = (string)userDoc["lastName"],
                    email = (string)userDoc["email"],
                    nrTickets = (int)userDoc["tickets"]
                };

            return null;

        }
        //Written by Cosmin Ilie: Updates the user's number of tickets
        public void UpdateUserTickets(User newUser)
        {
            UpdateDocument("users", "user_id", newUser.id, "tickets", newUser.nrTickets);
        }

        public void UpdateUserPassword(User user,string password)
        {
            UpdateDocument("users", "user_id", user.id, "password", password);
        }
    }
}
