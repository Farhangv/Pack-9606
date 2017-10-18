using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace HardInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDrives();
            Console.ReadKey();
        }

        private static void ShowDrives()
        {
            Console.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo drive in drives)
            for (int i = 0; i < drives.Length; i++)
            {
                if (drives[i].IsReady)
                    Console.WriteLine($"[{i}].{drives[i].Name}({drives[i].VolumeLabel})\t" +
                        $"Type:{drives[i].DriveType}\t{((drives[i].TotalSize / 1024) / 1024) / 1024}GB\t" +
                        $"{((drives[i].AvailableFreeSpace / 1024) / 1024) / 1024}GB\t" +
                        $"{drives[i].DriveFormat}");
            }
            Console.WriteLine("___________________");
            Console.Write("Select Drive Index:");
            var selectedIndex = int.Parse(Console.ReadLine());
            ShowContent(drives[selectedIndex].Name);
        }

        private static void ShowContent(string path)
        {
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo(path);//دایرکتوری جاری
            var subDirectories = di.GetDirectories();
            for (int i = 0; i < subDirectories.Length; i++)
            {
                Console.WriteLine($"[{i}].{subDirectories[i].Name}({subDirectories[i].FullName})");
            }
            var files = di.GetFiles();
            Console.WriteLine("------------");
            for (int i = subDirectories.Length; i < subDirectories.Length + files.Length; i++)
            {
                Console.WriteLine($"[{i}].{files[i - subDirectories.Length].Name}\t{files[i - subDirectories.Length].CreationTime}");
            }
            Console.WriteLine("___________________");
            Console.Write("Select Index:");
            var selectedIndex = int.Parse(Console.ReadLine());

            if (selectedIndex < 0)
            {
                if (di.FullName == di.Root.FullName)
                    ShowDrives();
                else
                    ShowContent(di.Parent.FullName);
            }
            else if (selectedIndex < subDirectories.Length)
                ShowContent(subDirectories[selectedIndex].FullName);
            else
                Process.Start(files[selectedIndex - subDirectories.Length].FullName);
        }
    }
}
