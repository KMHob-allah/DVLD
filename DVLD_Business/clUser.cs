using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clUser
    {      
        public enum eMode { Add, Update}

        public eMode Mode = eMode.Add; 
        public int PersonID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clPerson Person { get; set; }

        public clUser()
        {
            // Init Values For Empty Reference
            
            this.PersonID = -1;
            this.UserID = -1;


            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;

            Mode = eMode.Add;

        }
        private clUser(int PersonID, int UserID,string UserName, string Password, bool IsActive)
        {
            this.PersonID = PersonID;
            this.UserID = UserID;
          
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = eMode.Update;

            this.Person = clPerson.Find(PersonID);
        }      

        static public DataTable GetAllUsers()
        {
            return clUserData.LoadUsers();
        }

        static public clUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            
            string UserName = string.Empty;
            string Password = string.Empty;

            bool IsActive = false;

            if (clUserData.LoadUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clUser(PersonID, UserID, UserName, Password, IsActive);
            }

            else return null;

        }
        static public clUser FindByUserName(string UserName)
        {
            int PersonID = -1;
            int UserID   = -1;
         
            string Password = string.Empty;
            bool IsActive = false;

            if (clUserData.LoadUserByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clUser(PersonID, UserID, UserName, Password, IsActive);
            }

            else return null;

        }
        static public clUser FindByPersonID(int PersonID)
        {
            int UserID = -1;

            string UserName = string.Empty;
            string Password = string.Empty;

            bool IsActive = false;

            if (clUserData.LoadUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clUser(PersonID, UserID, UserName, Password, IsActive);
            }

            else return null;

        }
        static public clUser FindByUserNameAndPassword(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID   = -1;         

            bool IsActive = false;

            if (clUserData.LoadUserByUserNameAndPassword(ref UserID, ref PersonID,  UserName, Password, ref IsActive))
            {
                return new clUser(PersonID, UserID, UserName, Password, IsActive);
            }

            else return null;

        }

        static public bool IsExistByUserName(string UserName)
        {
            return clUser.IsExistByUserName(UserName);
        }

        static public bool IsExistByUserID(int UserID)
        {
            return clUser.IsExistByUserID(UserID);
        }
        static public bool IsExistByPersonID(int PersonID)
        {
            return clUser.IsExistByPersonID(PersonID);
        }
        private bool _AddNewUser()
        {
            this.UserID = clUserData.AddNewUser(this.PersonID, this.UserName, this.Password, IsActive);
            
            return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            return clUserData.UpdateUserInfo(this.UserID, this.UserName, this.Password, IsActive);

        }

        public bool Save()
        {
            bool IsSaved = false;

            switch(Mode)
            {
                case eMode.Add:
                {
                    IsSaved = _AddNewUser();

                    if (IsSaved) Mode = eMode.Update;

                    break;
                }

                case eMode.Update:
                {
                    IsSaved = _UpdateUser();
                    break;
                }
            }

            return IsSaved;
        }

        static public bool Delete(int UserID)
        {
            return clUserData.DeleteUser(UserID);
        }
    }
}
