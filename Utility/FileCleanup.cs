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
                string path = Directory.GetCurrentDirectory() + @"\cdktf.out\stacks\azure\";
                string[] keep = new[] { "terraform.exe", "terraform-provider-azurerm" };
                
                

                Console.WriteLine("Generated files have been deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
