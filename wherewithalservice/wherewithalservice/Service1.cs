using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace wherewithalservice
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //try
            //{
            //    try
            //    {
            //        if (!System.IO.Directory.Exists("XML"))
            //        {
            //            System.IO.Directory.CreateDirectory("XML");
            //        }
            //        if (!System.IO.Directory.Exists(@"XML\Erro"))
            //        {
            //            System.IO.Directory.CreateDirectory(@"XML\Erro");
            //        }
            //        if (!System.IO.File.Exists(@"XML\Erro\padrao.err"))
            //        {
            //            System.IO.File.Create(@"XML\Erro\padrao.err");
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        return;
            //    }
            //    try
            //    {
            //        uint procId = 0;
            //        var proc = Process.GetCurrentProcess();
            //        IntPtr hWnd = GetForegroundWindow();
            //        string url = string.Empty;
            //        var task = new Task(() => atualizaProcesso(procId, proc.ProcessName, url));
            //        Monitor.Database = new ConexaoDB("192.168.9.20", "5433", "postgres", "wherewithal", "wherewithal", true, MsgType.Msg);
            //        Monitor.NomeEstacao = Environment.MachineName;
            //        Monitor.graveiStartBuild = false;
            //        DateTime dataHoraBuildMaisVelho = DateTime.MaxValue;
            //        while (true)
            //        {
            //            try
            //            {

            //                //(new List<browserlocation.URLDetails>(browserlocation.InternetExplorer())).ForEach(u =>
            //                //            {
            //                //                Console.WriteLine("[{0}]\r\n{1}\r\n", u.Title, u.URL);
            //                //            });

            //                hWnd = GetForegroundWindow();
            //                procId = 0;
            //                GetWindowThreadProcessId(hWnd, out procId);
            //                proc = Process.GetProcessById((int)procId);

            //                //Console.WriteLine(proc.MainModule);
            //                if (proc.ProcessName.Equals("firefox") || proc.ProcessName.Equals("chrome")/* || proc.ProcessName.Equals("iexplore")*/) // IE está pegando os endereços de todas as abas, não apenas a que está em foco
            //                {
            //                    url = string.Empty;

            //                    if (proc.ProcessName.Equals("iexplore"))
            //                    {
            //                        (new List<URLDetails>(InternetExplorer())).ForEach(u =>
            //                        {
            //                            url += u.URL;
            //                            //Console.WriteLine("[{0}]\r\n{1}\r\n", u.Title, u.URL);
            //                        });
            //                    }
            //                    else
            //                    {
            //                        url = GetChromeUrl(proc);
            //                    }

            //                    if (url == null)
            //                        continue;
            //                    url = url.ToLower();
            //                    url = url.Replace("http://", string.Empty).Replace("https://", string.Empty).Replace("ftp://", string.Empty);
            //                    if (url.Contains("/"))
            //                    {
            //                        url = url.Substring(0, url.IndexOf("/"));
            //                    }

            //                    //Console.WriteLine(proc.ProcessName + " Url for '" + proc.MainWindowTitle + "' is " + url);
            //                }
            //                else
            //                {
            //                    url = string.Empty;
            //                }


            //                task = new Task(() => atualizaProcesso(procId, proc.ProcessName, url));
            //                task.Start();

            //                /*Process[] localByName = Process.GetProcessesByName("MSBuild");

            //                if (localByName.Count() > 0)
            //                {
            //                    if (Monitor.graveiStartBuild == false)
            //                    {
            //                        procId = 0;
            //                        foreach (Process item in localByName)
            //                        {
            //                            if (procId < item.Id)
            //                            {
            //                                procId = (uint)item.Id;
            //                                dataHoraBuildMaisVelho = item.StartTime;
            //                            }

            //                        }
            //                        task = new Task(() => compileStart(localByName[0].ProcessName, dataHoraBuildMaisVelho));
            //                        task.Start();
            //                        Monitor.graveiStartBuild = true;
            //                    }
            //                }
            //                else
            //                {
            //                    if (Monitor.graveiStartBuild == true)
            //                    {
            //                        task = new Task(() => compileStop(DateTime.Now));
            //                        task.Start();
            //                        Monitor.graveiStartBuild = false;
            //                    }
            //                }*/



            //            }
            //            catch (Exception ex)
            //            {

            //            }
            //            //task.Start();
            //            //Console.ReadKey();
            //            System.Threading.Thread.Sleep(1000); // Test it with 5 Seconds, set a window to foreground, and you see it works!
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return;
            //}
        }

        protected override void OnStop()
        {
        }

        public void TODO()
        {

        }
    }
}
