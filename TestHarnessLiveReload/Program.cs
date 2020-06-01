using System;
using System.IO;
using Westwind.AspNetCore.LiveReload;

namespace TestHarnessLiveReload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up test pre-condition.
            //Folder to monitor should be present to start with as existing code in LiveReleoadFileWatcher.StartFileWatcher()
            // that gets the full path will throw execption if the path doesn't exist and I don't want to change this behaviour
            // without due thought into it
            Directory.CreateDirectory("dist");

            LiveReloadConfiguration config =
                new LiveReloadConfiguration
                {
                    LiveReloadEnabled = true,
                    FolderToMonitor = @"dist" // Change this to a folder of your choice
                };
            LiveReloadConfiguration.Current = config;

            LiveReloadFileWatcher.StartFileWatcher();

            Console.ReadLine();
        }
    }
}
