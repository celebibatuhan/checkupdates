using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace checkupdates
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\batuhan.celebi\Informations");

            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;

            watcher.Deleted += watcher_Deleted;
            watcher.Changed += watcher_Changed;
            watcher.Created += watcher_Created;
            watcher.Renamed += watcher_Renamed;
            
            while (true) ;
        }
        private static void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0} deleted at time : {1}", e.Name, DateTime.Now.ToLocalTime());
        }
        private static void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File : {0} renamed to {1} at time : {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime());
        }
        private static void watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0}  created at time : {1}", e.Name, DateTime.Now.ToLocalTime());
        }
        private static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0} changed at time : {1}", e.Name, DateTime.Now.ToLocalTime());
        }
    }
}
