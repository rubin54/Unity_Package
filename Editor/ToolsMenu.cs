using UnityEditor;
using static UnityEditor.AssetDatabase;

namespace justinmaetschke
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Folders.CreateDirectories("_Project", "Scripts", "Art", "Scenes", "Prefabs");
            Refresh();
        }

        [MenuItem("Tools/Setup/Load New Manifest")]
        static async void LoadNewManifest() => await Packages.ReplacePackageFromGist("c5b6124448ed88feecadda3d5d9adbba");

        [MenuItem("Tools/Setup/Packages/New Input System")]
        static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");

        [MenuItem("Tools/Setup/Packages/Post Processing")]
        static void AddPostProcessing() => Packages.InstallUnityPackage("postprocessing");

        [MenuItem("Tools/Setup/Packages/Cinemachine")]
        static void AddCinemachine() => Packages.InstallUnityPackage("cinemachine");
    }
}
