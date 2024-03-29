﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BugGUI
{
    [Serializable]
    public class GamesDirectory
    {
        public string Name;
        public DirectoryInfo DirectoryInfo;
        public string[] Extensions;

        public override string ToString()
        {
            string result = $"{Name} ({DirectoryInfo.FullName})";
            return result;
        }
    }

    // TODO(SpectatorQL): Clean up serialization!
    public class Config
    {
        string ConfigFileName; // NOTE(SpectatorQL): I'm not a fan of this.
        public List<GamesDirectory> GamesDirectories { get; }
        [NonSerialized] BinaryFormatter Formatter = new BinaryFormatter();

        public Config()
        {
            ConfigFileName = "config.dat";

#if false
            if(File.Exists(ConfigFileName))
            {
                File.Delete(ConfigFileName);
            }
#endif
            
            FileStream configFileStream;
            if(File.Exists(ConfigFileName))
            {
                configFileStream = File.Open(ConfigFileName, FileMode.Open, FileAccess.Read, FileShare.None);
                GamesDirectories = (List<GamesDirectory>)Formatter.Deserialize(configFileStream);
                configFileStream.Close();
            }
            else
            {
                configFileStream = File.Open(ConfigFileName, FileMode.Create, FileAccess.Write, FileShare.None);
                GamesDirectories = new List<GamesDirectory>();

                Formatter.Serialize(configFileStream, GamesDirectories);
                configFileStream.Close();
            }
        }

        void PrintDirectoryList()
        {
#if DEBUG
            for(int i = 0;
                i < GamesDirectories.Count;
                ++i)
            {
                var thing = GamesDirectories[i];
                if(thing != null)
                {
                    Debug.WriteLine($"{i}: {thing.ToString()}");
                }
                else
                {
                    Debug.WriteLine($"{i}: null");
                }
            }
            Debug.Write("\n");
#endif
        }

        public void Update()
        {
            using(FileStream configFileStream = File.Open(ConfigFileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Formatter.Serialize(configFileStream, GamesDirectories);
            }
            PrintDirectoryList();
        }

        public List<GamesDirectory> AddGamesDirectory(GamesDirectory newDirectory)
        {
            GamesDirectories.Add(newDirectory);
            Update();

            return GamesDirectories;
        }

        public List<GamesDirectory> RemoveGamesDirectory(int index)
        {
            GamesDirectories.RemoveAt(index);
            Update();

            return GamesDirectories;
        }
    }
}
