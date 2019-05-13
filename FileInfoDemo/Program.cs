using System;
using System.IO;

namespace CSharpFundamentals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }
            fileInfo.OpenRead;
        }
    }
}
