using System;
using System.Threading.Tasks;


namespace R5T.S0048
{
    class Program
    {
        static async Task Main()
        {
            //await ProjectFileOperations.Instance.Resolve_NETSDK1138_TargetFrameworkOutOfSupportWarning_NoCheck();

            //await ProjectFileScripts.Instance.Create_OnlyProjectElement();
            //await ProjectFileScripts.Instance.Create_Library();
            //await ProjectFileScripts.Instance.Create_Console();
            await ProjectFileScripts.Instance.Create_WebServerForBlazorClient();
            //await ProjectFileScripts.Instance.Create_WebApplication();
            //ProjectFileScripts.Instance.CreateNewNet6WebAssemblyServerProject();
            //ProjectFileScripts.Instance.FindAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue();
            //ProjectFileScripts.Instance.UpdateAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue();
        }
    }
}