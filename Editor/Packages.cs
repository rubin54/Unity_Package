using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace justinmaetschke
{
    public static class Packages
    {
        public static async Task ReplacePackageFromGist(string id, string user = "rubin54")
        {
            var url = GetGistUrl(id, user);
            var contents = await GetContents(url);
            ReplacePackageFiles(contents);
        }

        static string GetGistUrl(string id, string user = "rubin54") =>
            $"https://gist.githubusercontent.com/{user}/{id}/raw";

        static async Task<string> GetContents(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }



        static void ReplacePackageFiles(string contents)
        {
            var existing = Path.Combine(Application.dataPath, "../Packages/manifest.json");
            File.WriteAllText(existing, contents);
            UnityEditor.PackageManager.Client.Resolve();

        }

        public static void InstallUnityPackage(string packageName) => UnityEditor.PackageManager.Client.Add($"com.unity.{packageName}");
    }
}