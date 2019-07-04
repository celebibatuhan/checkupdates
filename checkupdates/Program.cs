using System;
using System.IO;

namespace checkupdates
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\batuhan.celebi\Informations");

            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;

            watcher.Deleted += Watcher_Deleted;
            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            
            while (true) ;
        }
        private static void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0} deleted at time : {1}", e.Name, DateTime.Now.ToLocalTime());
        }
        private static void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File : {0} renamed to {1} at time : {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime());
        }
        private static void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0}  created at time : {1}", e.Name, DateTime.Now.ToLocalTime());
        }
        private static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0} changed at time : {1}", e.Name, DateTime.Now.ToLocalTime());
        }
    }
}
