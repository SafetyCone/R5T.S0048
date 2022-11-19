using System;
using System.Threading.Tasks;


namespace R5T.S0048
{
    class Program
    {
        static async Task Main()
        {
            await ProjectFileOperations.Instance.Resolve_NETSDK1138_TargetFrameworkOutOfSupportWarning_NoCheck();

            //ProjectFileScripts.Instance.CreateNewMinimalProject();
            //ProjectFileScripts.Instance.CreateNewNet6WebAssemblyServerProject();
        }
    }
}