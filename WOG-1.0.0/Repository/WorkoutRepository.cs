using System.Text.Json;
using System.Text.Json.Serialization;
using WOG_1._0._0.Models;

namespace WOG_1._0._0.Repository
{
    public class WorkoutRepository
    {

        public List<Exercise> GetExercises()
        {
            string dir = Directory.GetCurrentDirectory();
            string pathFromDir = "Repository\\exercises.json";

            string fileContents = File.ReadAllText(Path.Combine(dir, pathFromDir));

            List<Exercise> exercises = JsonSerializer.Deserialize<List<Exercise>>(fileContents) ??
                throw new Exception("Could not deserialize exercies");

            return exercises;
        }
    }
}
