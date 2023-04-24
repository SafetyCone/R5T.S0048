using System;
using System.Threading.Tasks;


namespace R5T.S0048
{
    class Program
    {
        static async Task Main()
        {
            //await ProjectFileOperations.Instance.Resolve_NETSDK1138_TargetFrameworkOutOfSupportWarning_NoCheck();

            await ProjectFileScripts.Instance.New_OnlyProjectElement();
            //await ProjectFileScripts.Instance.New_Library();
            //await ProjectFileScripts.Instance.New_Console();
            //await ProjectFileScripts.Instance.New_WebServerForBlazorClient();
            //await ProjectFileScripts.Instance.New_WebApplication();
            //await ProjectFileScripts.Instance.New_Net6WebAssemblyServerProject();
            //await ProjectFileScripts.Instance.New_OnlyProjectElementWithSdk();
            //await ProjectFileScripts.Instance.New_RazorClassLibrary();
            //await ProjectFileScripts.Instance.New_WebBlazorClient();
            //await ProjectFileScripts.Instance.New_WebStaticRazorComponents();
            //await ProjectFileScripts.Instance.New_WindowFormsApplication();
            //await ProjectFileScripts.Instance.New_WindowsFormsLibrary();
            //await ProjectFileScripts.Instance.New_DeployScripts();

            //await ProjectFileScripts.Instance.Is_RazorComponentsLibrary();

            //ProjectFileScripts.Instance.FindAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue();
            //ProjectFileScripts.Instance.UpdateAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue();
        }
    }
}