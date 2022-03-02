using System.IO;
using UnityEngine;

namespace justinmaetschke
{
    public static class Folders
    {
        public static void CreateDirectories(string root, params string[] dir)
        {
            foreach (var newDirectory in dir)
                Directory.CreateDirectory(Path.Combine(Application.dataPath, root, newDirectory));
        }
    }
}

