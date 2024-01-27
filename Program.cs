using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             ProcessStartInfo startInfo = new ProcessStartInfo();
             startInfo.FileName = "AcroRd32.exe";
            string args = string.Format("-print-to-default \"{0}\" -exit-when-done", "xx.pdf");
            startInfo.Arguments = args;
            startInfo.CreateNoWindow = true;
            startInfo.ErrorDialog = false;
            startInfo.UseShellExecute = false;
            Process process = Process.Start(startInfo); 
            Console.WriteLine("Start Print.");
        //process.Exited += process_Exited;
        Recheck:
            if (!process.HasExited)
            {
                Console.WriteLine("Wait 1 Sec.");
                process.WaitForExit(1000);
                goto Recheck;
            }
            else
            {
                Console.WriteLine("Print Finish.");
                Console.ReadLine();
            }
            Console.ReadLine();

        }
           
        }
    }

