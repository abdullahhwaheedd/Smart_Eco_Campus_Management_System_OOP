using SECMSS.DL;
using SECMSS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



    class UserBL
    {
        private UserDL userDL = new UserDL();
   

        public bool IsNameValid(string name)
        {
            
            return !string.IsNullOrEmpty(name) && name.Trim().Length >= 3;
        }

        
        public bool IsAgeValid(int age)
        {
            
            return age >= 16 && age <= 100;
        }

       
        public bool IsPasswordValid(string password)
        {
           

            return !string.IsNullOrEmpty(password) && password.Length >= 5 && password.Contains("@") ;
            
        }

        public string CheckEmailAvailability(string email)
        {
            if (string.IsNullOrEmpty(email))
                return "Email cannot be empty.";

            if (!email.EndsWith("@eco.com") )
                return "Invalid email format (it should end at @eco.com)";

           
            if (userDL.IsEmailExists(email))
                return "This email is already registered.";

            return "Available";
        }


    

        public string SignUpReporter(UserModel user)
        {
         
            if (!IsNameValid(user.Name)) return "Invalid Name.";
            if (!IsAgeValid(user.Age)) return "Invalid Age.";
            if (CheckEmailAvailability(user.Email) != "Available") return "Email is not available.";
            if (!IsPasswordValid(user.Password)) return "Invalid Password.";


            bool isSaved = userDL.SignUpReporter(user);

            if (isSaved)
                return "Success";
            else
                return "Error: Database could not save the record.";
        }
        public UserModel Login(string email, string password)
        {
           
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            { 
                return null;
            }
            UserModel loggedInUser = userDL.Login(email, password);
            return loggedInUser;
        }
        
        public List<UserModel> GetAllUsers()
        {
            return userDL.GetAllUsers();
        }
        public string DeleteAccount(int userId)
        {
            
            bool isDeleted = userDL.DeleteUser(userId);

            if (isDeleted)
            {
                return "Success";
            }
            else
            {
                return "Could not delete user from database.";
            }
        }
       
    }


