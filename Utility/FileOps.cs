using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VFrameworkBlazor.Utility
{
    static class FileOps
    {
        internal static string _solutionDir = Directory.GetCurrentDirectory();

        internal static void CleanUpOutFolder()
        {
            try
            {
                string path = _solutionDir + @"\cdktf.out\stacks\azure\";
                string[] keep = new[] { "terraform.exe", "terraform-provider-azurerm" };

                Console.WriteLine("Generated files have been deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        internal static Dictionary<string, string> JsonFileToDict (string fileLoc)
        {
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(fileLoc));
            }

            catch(Exception e)
            {
                return new Dictionary<string, string>() { { "error", e.ToString() } };
            }
        }
    }
}
