using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileSorter
{
    class Filesort
    {
        static void Main()
        {

            string sourceDirectory = @"c:\Users\epmor_000\Documents\textcontainer";
            string targetDirectory = @"c:\Users\epmor_000\Documents\textdestination";


            DirectoryInfo txtinfo = new DirectoryInfo(sourceDirectory);
            FileInfo[] filelist = txtinfo.GetFiles();

            foreach (FileInfo textcheck in filelist)
            {
                if (CheckFile(textcheck))
                {
                    File.Copy(Path.Combine(sourceDirectory, textcheck.Name), Path.Combine(targetDirectory, textcheck.Name), true);
                }
            }

        }
        static bool CheckFile(FileInfo textcheck)
        {
            DateTime today = DateTime.Now;
            DateTime yesterday = today.AddDays(-1);

            if (textcheck.LastWriteTime > yesterday)
            {


                return true;
            }
            else
            {
                return false;
            }
        }
    }

}


