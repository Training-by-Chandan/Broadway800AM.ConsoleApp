using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public class FileOperation
    {
        private static string BasePath = "D:\\Projects\\Broadway\\bikash";

        //system.io
        public static void DirectoryOperation()
        {
            //Console.WriteLine("Enter the foldername you want to create");
            //var foldername = Console.ReadLine();

            //var fodlerexists = System.IO.Directory.Exists(BasePath + "\\" + foldername);
            //if (!fodlerexists)
            //{
            //    System.IO.Directory.CreateDirectory(BasePath + "\\" + foldername);
            //    Console.WriteLine($"Folder {foldername} created");
            //}
            //else
            //{
            //    Console.WriteLine($"Folder {foldername} already exists");
            //}

            var list = System.IO.Directory.GetDirectories(BasePath);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //gives the information of the specified folder
            var info = new System.IO.DirectoryInfo(BasePath);
        }

        public static void FileOps()
        {
            //Console.WriteLine("Enter the filename with extension you want to create");
            //var filename = Console.ReadLine();
            //Console.WriteLine("Enter the content you want to create");
            //var content = Console.ReadLine();

            //var fileexists = System.IO.File.Exists(BasePath + "\\" + filename);
            //if (fileexists)
            //{
            //    var file = System.IO.File.AppendText(BasePath + "\\" + filename);
            //    file.WriteLine(content);
            //    file.Close();
            //}
            //else
            //{
            //    var file = System.IO.File.CreateText(BasePath + "\\" + filename);
            //    file.WriteLine(content);
            //    file.Close();
            //}

            //Console.WriteLine("Content from file");
            //var contents = System.IO.File.ReadAllBytes(BasePath + "\\fz.exe");
            //System.IO.File.WriteAllBytes(BasePath + "\\fz-new.exe", contents);

            var path = System.IO.Path.GetFullPath(BasePath);
            var fzpath = System.IO.Path.Combine(path, "fz.exe");

            var directory = System.IO.Path.GetDirectoryName(fzpath);
            var filename = System.IO.Path.GetFileName(fzpath);
            var filenamewithoutextension = System.IO.Path.GetFileNameWithoutExtension(fzpath);
            var extension = System.IO.Path.GetExtension(fzpath);
        }
    }
}