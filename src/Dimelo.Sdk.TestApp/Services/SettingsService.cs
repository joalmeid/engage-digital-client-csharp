using Dimelo.Sdk.TestApp.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;

namespace Dimelo.Sdk.TestApp.Services
{
    public static class SettingsService
    {
        // singleton lock with 1 thread access at the same time
        // source: https://blog.cdemi.io/async-waiting-inside-c-sharp-locks/ 
        private static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
        public const string SETTINGS_FILENAME = "Settings.json";

        public async static Task<Settings> LoadAsync()
        {
            await semaphore.WaitAsync();
            try
            {
                StorageFile file = (StorageFile)await ApplicationData.Current.LocalFolder.TryGetItemAsync(SETTINGS_FILENAME);
                if (file == null)
                {
                    return new Settings();
                }
                else
                {
                    string json = await FileIO.ReadTextAsync(file);
                    return JsonConvert.DeserializeObject<Settings>(json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}: {ex.ToString()}");
                return null;
            }
            finally
            {
                semaphore.Release();
            }
        }

        public async static Task SaveAsync(Settings settings)
        {
            await semaphore.WaitAsync();
            try
            {
                StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(SETTINGS_FILENAME, CreationCollisionOption.ReplaceExisting);
                string json = JsonConvert.SerializeObject(settings);
                await FileIO.WriteTextAsync(file, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}: {ex.ToString()}");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
