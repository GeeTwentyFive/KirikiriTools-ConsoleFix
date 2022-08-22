using System;
using System.IO;

namespace Arc.Ddsi.Xp3Pack
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: Xp3Pack folder");
                return;
            }

            string folderPath = args[0];
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Specified folder does not exist.");
                return;
            }

            int end = 0;
            string parentDir = "";
            for (int i = folderPath.Length - 1; i >= 0; --i)
            {
                if (folderPath[i].Equals("\\") || folderPath[i].Equals("/"))
                {
                    end = i;
                }
            }
            for (int i = 0; i < end; ++i)
            {
                parentDir += folderPath[i];
            }

            string xp3FilePath = parentDir + "patch.xp3";
            Xp3ArchiveWriter.Write(folderPath, xp3FilePath);
        }
    }
}
