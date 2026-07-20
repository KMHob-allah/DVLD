using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clPerson
    {
       // Why He Made _ImagePath Private ??
       // We Added CountryInfo As A Composition Method 


        public enum eGender { Male, Female, Unknown }
        public enum eMode { Add, Update};

        private string _ImagePath;


        public clCountry CountryInfo;


        public eMode Mode = eMode.Add;
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int NationalityCountryID { get; set; }
        public eGender Gender { get; set; }
        public string ImagePath
        {
            set { _ImagePath = value; }
            get { return _ImagePath; }
        }

        public clPerson()
        {
            // Init Values For Empty Reference

            this.PersonID = -1;
            this.NationalNumber = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.BirthDate = DateTime.MinValue;
            this.Address = string.Empty;
            this.ImagePath = string.Empty;
            this.NationalityCountryID = -1;
            this.Gender = eGender.Unknown;
            //this.CountryInfo = new clCountry();

            Mode = eMode.Add;
        }
        private clPerson(int personID, string NationalNumber, string FirstName, string SecondName, string ThirdName, string LastName,
            string Email, string Phone, DateTime BirthDate, string Address, string ImagePath,
            int NationalityCountryID, eGender Gender)
        {
            this.PersonID = personID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.BirthDate = BirthDate;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.NationalityCountryID = NationalityCountryID;
            this.Gender = Gender;
            this.CountryInfo = clCountry.Find(NationalityCountryID);
        }

        public string stGender()
        {
            switch(Gender)
            {
                case eGender.Male:

                    return "Male";

                case eGender.Female:

                    return "Female";

                default:

                    return "Unknown";
            }
          
        }
        public string FullName()
        {
            if(string.IsNullOrEmpty(ThirdName)) return $"{this.FirstName} {this.SecondName} {this.LastName}";

            else return $"{this.FirstName} {this.SecondName} {this.ThirdName} {this.LastName}";
        }
        public bool IsMale()
        {
            return Gender == eGender.Male;
        }

        private bool _AddNewPerson()
        {       
            this.PersonID = clPersonData.AddNewPerson(
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNumber, Convert.ToByte(this.Gender),
                this.Email, this.Address, this.BirthDate, this.Phone,
                this.NationalityCountryID, this.ImagePath);

            return PersonID != -1;
        }
        private bool _UpdatePerson()
        {
            
            return clPersonData.UpdatePersonInfo(this.PersonID,
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNumber, Convert.ToByte(this.Gender),
                this.Email, this.Address, this.BirthDate, this.Phone,
                this.NationalityCountryID, this.ImagePath);

        }
        static public bool Delete(int PersonID)
        {
            return clPersonData.DeletePerson(PersonID);
        }

        public bool Save()
        {
            bool IsSaved = false;

            switch(Mode)
            {
                case eMode.Add:
                {
                    
                    IsSaved = _AddNewPerson();
                    break;
                }

                case eMode.Update:
                {
                    IsSaved =  _UpdatePerson();
                    break;
                }
            }

            return IsSaved;
        }

        static public DataTable GetAllPeopleList()
        {
            return clPersonData.LoadAllPeople();
        }

        static public clPerson Find(int PersonID)
        {
            string NationalNumber = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;
            DateTime BirthDate = DateTime.MinValue;
            string Address = string.Empty;
            string ImagePath = string.Empty;
            int CountryID = -1;
            byte Gender = Convert.ToByte(eGender.Unknown);

            if (clPersonData.LoadPerson(PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref Email, ref Phone, ref BirthDate, ref Address, ref ImagePath, ref CountryID, ref Gender))
            {
                return new clPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName,
                LastName, Email, Phone, BirthDate, Address, ImagePath, CountryID, (eGender)Gender);
            }

            else return null;

        }
        static public clPerson Find(string NationalNumber)
        {
            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;
            DateTime BirthDate = DateTime.MinValue;
            string Address = string.Empty;
            string ImagePath = string.Empty;
            int CountryID = -1;
            byte Gender = Convert.ToByte(eGender.Unknown);

            if (clPersonData.LoadPerson(ref PersonID, NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref Email, ref Phone, ref BirthDate, ref Address, ref ImagePath, ref CountryID, ref Gender))
            {
                return new clPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName,
                LastName, Email, Phone, BirthDate, Address, ImagePath, CountryID, (eGender)Gender);
            }

            else return null;

        }

        static public bool Exist(int PersonID)
        {
            return clPersonData.IsExist(PersonID);
        }
        static public bool Exist(string NationalNumber)
        {
            return clPersonData.IsExist(NationalNumber);
        }        

    }
}
