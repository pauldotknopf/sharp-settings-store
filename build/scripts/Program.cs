using Build.Buildary;

namespace Build
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = Runner.ParseOptions<Runner.RunnerOptions>(args);
            
            ProjectDefinition.Register(options, new ProjectDefinition
            {
                SolutionPath = "./SharpSettingsStore.sln"
            });
            
            Runner.Execute(options);
        }
    }
}