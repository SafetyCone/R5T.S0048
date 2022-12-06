using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using R5T.F0020;
using R5T.T0132;


namespace R5T.S0048
{
	[FunctionalityMarker]
	public partial interface IProjectFileScripts : IFunctionalityMarker
	{
		/// <summary>
		/// Script testing logic to determine if a project is a Razor components library.
		/// </summary>
		public async Task Is_RazorComponentsLibrary()
		{
            /// Inputs.
            var projectFilePath =
                //Instances.ProjectFilePaths.Example
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0065.Private\source\R5T.E0065.R002\R5T.E0065.R002.csproj"
                ;


            /// Run.
            var isRazorComponentsLibrary = await F0081.ProjectFileOperations.Instance.Is_RazorComponentsLibrary(
                projectFilePath);

			Console.WriteLine($"{isRazorComponentsLibrary}: is Razor components library:\n{projectFilePath}");
        }

		public async Task Create_WebApplication()
		{
            /// Inputs.
            var projectFilePath =
                Instances.ProjectFilePaths.Example
                ;


            /// Run.
            await F0081.ProjectFileOperations.Instance.CreateNewProjectFile_Web(
                projectFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
                projectFilePath);
        }

		public async Task Create_WebServerForBlazorClient()
		{
			/// Inputs.
			var projectFilePath =
				Instances.ProjectFilePaths.Example
				;


			/// Run.
			await F0081.ProjectFileOperations.Instance.CreateNewProjectFile_WebServerForBlazorClient(
				projectFilePath);

			F0033.NotepadPlusPlusOperator.Instance.Open(
				projectFilePath);
		}

		public async Task Create_Console()
        {
            /// Inputs.
            var projectFilePath =
                Instances.ProjectFilePaths.Example
                ;


            /// Run.
            await F0081.ProjectFileOperations.Instance.CreateNewProjectFile_Console(
                projectFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
                projectFilePath);
        }

        public async Task Create_Library()
		{
            /// Inputs.
            var projectFilePath =
				Instances.ProjectFilePaths.Example
				;


			/// Run.
			await F0081.ProjectFileOperations.Instance.CreateNewProjectFile_Library(
				projectFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
                projectFilePath);
        }

        /// <summary>
        /// <inheritdoc cref="FindAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue" path="/summary/net5-eol-issue"/>
        /// Update the projects by adding the CheckEolTargetFramework attribute and/or setting it to true.
        /// </summary>
        public void UpdateAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue()
		{
			F0035.LoggingOperator.Instance.InConsoleLoggerContext_Synchronous(
				nameof(UpdateAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue),
				logger =>
				{
                    var projectFilePaths = Operations.Instance.GetAllProjectFilePaths(
						logger);

                    var projectsOfInterest = projectFilePaths
                        .Where(Operations.Instance.NoCheckEolTargetFrameworkElementOrTrue)
                        .Now();

                    foreach (var projectFilePath in projectsOfInterest)
                    {
						logger.LogInformation("Updating project file:\n\t{projectFilePath}", projectFilePath);

                        ProjectFileOperator.Instance.InModifyProjectFileContext_Synchronous(
                            projectFilePath,
                            projectElement =>
                            {
                                ProjectXmlOperator.Instance.SetCheckEolTargetFramework(
                                    projectElement,
                                    false);
                            });
                    }
                });
        }

        /// <summary>
        /// <net5-eol-issue>Now that .NET 5 is end-of-life (EOL), Visual Studio is being super-annoying, putting up a warning for all .NET 5 projects.</net5-eol-issue>
        /// Find problem projects.
        /// </summary>
        public void FindAllNet5ProjectsWithoutCheckEolTargetFrameworkOrTrue()
		{
			var projectFilePaths = Operations.Instance.GetAllProjectFilePaths();

			var projectsOfInterest = projectFilePaths
				.Where(Operations.Instance.NoCheckEolTargetFrameworkElementOrTrue)
				.ExplicitNoneIfNone()
				.Now();

            F0033.NotepadPlusPlusOperator.Instance.WriteLinesAndOpen(
				Z0015.FilePaths.Instance.OutputTextFilePath,
				projectsOfInterest);
		}

		public void CreateNewNet6WebAssemblyServerProject()
        {
			/// Inputs.
			var projectFilePath = Instances.ProjectFilePaths.Example;


			/// Run.
			var projectElement = Instances.ProjectXmlOperator.CreateNew();

			Instances.ProjectXmlOperator.SetSdk(
				projectElement,
				ProjectSdkStrings.Instance.Web);

			Instances.ProjectXmlOperator.SetTargetFramework(
				projectElement,
				TargetFrameworkMonikerStrings.Instance.NET_6);

			var blazorWebAssemblyServer = Z0020.Packages.Instance.Microsoft_AspNetCore_Components_WebAssembly_Server;
			Instances.ProjectXmlOperator.AddPackageReference_Idempotent(
				projectElement,
				blazorWebAssemblyServer.Identity,
				blazorWebAssemblyServer.Version);

			Operations.Instance.OutputToFileAndOpen(
				projectElement,
				projectFilePath);
		}

		/// <summary>
		/// Creates a project file with *only* the project element.
		/// </summary>
		public async Task Create_OnlyProjectElement()
        {
            /// Inputs.
            var projectFilePath = Instances.ProjectFilePaths.Example;


			/// Run.
			await F0081.ProjectFileOperations.Instance.Create_OnlyProjectElement(
				projectFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
				projectFilePath);
        }
	}
}