using System;
using System.IO;

namespace VFrameworkBlazor.Utility
{
    static class FileCleanup
    {
        internal static void CleanUpOutFolder()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\cdktf.out\"; // get the path of cdktf.out folder
                Console.WriteLine(path);
                if (Directory.Exists(path))
                {
                    DirectoryInfo di = new DirectoryInfo(path); // Instantiate a DirectoryInfo object for easy enumeration and deletion of files and directories
                    foreach(FileInfo file in di.GetFiles()) 
                    {
                        file.Delete(); // Delete the files after being done 
                    }
                    foreach(DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true); // Delete the folders once they are empty
                    }
                }
                Directory.Delete(path);
                Console.WriteLine("Generated files have been deleted");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
