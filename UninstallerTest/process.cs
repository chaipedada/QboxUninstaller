using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UninstallerTest
{
    public class processes
    {
        public void run(){
            if (globals.QboxAppState == false)
            {
                Process p = new Process();
                p.StartInfo.FileName = "rundll32.exe"; //Run the uninstall executable with the uninstall string
                p.StartInfo.Arguments = "dfshim.dll,ShArpMaintain QBoxClient.application, Culture=en, PublicKeyToken=c7c5fb3875c039a3, processorArchitecture=x86";
                p.Start();
                p.WaitForExit();
                if (globals.systemDataUninstall == true)
                {
                    //string[] s = System.IO.Directory.GetDirectories(@"C:\Users\", "*"); //Delete the system data files
                        string dataLoc = @"C:\Users\" + globals.user + @"\AppData\Local\CoralTree"; //adds the rest of the path to the user found via wildcard
                        if (System.IO.Directory.Exists(dataLoc))
                        {
                            try
                            {
                                System.IO.Directory.Delete(dataLoc, true);
                            }

                            catch (System.IO.IOException a)
                            {
                                Console.WriteLine(a.Message);
                            }
                        }
                }
                Window3 openWindow = new Window3();
                openWindow.Show();
            }
        }
    }
}
