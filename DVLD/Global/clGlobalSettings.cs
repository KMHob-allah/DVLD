using DVLD_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.GlobalSettings
{
    static internal class clGlobalSettings
    {
        static public clUser CurrentUser { get ; set; }
        static private string GetFilePath()
        {
            string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DVLD_System");

            if(!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);

            return Path.Combine(FolderPath, "data.txt");
        }

        public static bool RememberUsernameAndPassword(string UserName, string Password)
        {
            try
            {
                string FilePath = GetFilePath();

                if(string.IsNullOrEmpty(UserName) && File.Exists(FilePath))
                {
                    File.Delete(FilePath);

                    return true;
                }

                string DataToSave = UserName + "#//#" + Password;
                             
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine(DataToSave);

                    return true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            try
            {
                string FilePath = GetFilePath();
               
                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string Line;

                        while ((Line = reader.ReadLine()) != null && Line != "#//#")
                        {
                            Console.WriteLine(Line); 

                            string[] Result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            if(Result.Length >= 2) 
                            { 
                                UserName = Result[0];
                                Password = Result[1];                     
                            }
                            return true;
                        }

                        return false;
                    }
                }

                else return false;                
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}
