using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Helper
    {
        public static async Task CreateFile<M>(string folderPath, string fileName, M obj)
        {
            var fullPath = Path.Combine(folderPath, fileName);

            try
            {
                if (!File.Exists(fullPath))
                {
                    var list = new List<M> { obj };
                    var jsonString = JsonSerializer.Serialize(list);
                    await File.WriteAllTextAsync(fullPath, jsonString);
                    Console.WriteLine($"Creation of {fileName} is done.");
                }
                else
                {
                    var content = await File.ReadAllTextAsync(fullPath);
                    var existingItems = JsonSerializer.Deserialize<List<M>>(content);
                    existingItems.Add(obj);

                    var updatedJsonString = JsonSerializer.Serialize(existingItems);
                    await File.WriteAllTextAsync(fullPath, updatedJsonString);
                    Console.WriteLine($"Updated {fileName} successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.ToString()}");
            }
        }


        public static async Task<List<M>> ReadFile<M>(string fullPath)
        {
            //var fullPath = Path.Combine(folderPath, fileName);
            var result = new List<M>();

            if (File.Exists(fullPath))
            {
                try
                {
                    var jsonString = await File.ReadAllTextAsync(fullPath);
                    result = JsonSerializer.Deserialize<List<M>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

            return result;
        }
    }
}
