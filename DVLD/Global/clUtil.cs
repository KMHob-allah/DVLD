using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Global
{
    public class clUtil
    {
        public static string GenerateGUID()
        {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();            
        }
        public static bool CreateFolderIfNotExist(string FolderPath)
        {                   
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;            
        }     
        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            string FileName = SourceFile;
            FileInfo FileInfo = new FileInfo(FileName);
            string Extension = FileInfo.Extension;
            return GenerateGUID() + Extension;
        }       
        public static  bool CopyImageToProjectImagesFolder(ref string  SourceFile)
        {          
            string DestinationFolder = @"C:\DVLD-People-Images\";

            if (!CreateFolderIfNotExist(DestinationFolder)) return false;  

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);

            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }

            catch (IOException iox)
            {
                MessageBox.Show (iox.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceFile = DestinationFile;

            return true;
        }
    }
}
