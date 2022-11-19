using System;

using R5T.T0132;


namespace R5T.S0048
{
	[FunctionalityMarker]
	public partial interface IScripts : IFunctionalityMarker
	{
		public void CreateNewNet6WebAssemblyServerProject()
        {
			/// Inputs.
			var projectFilePath = Instances.ProjectFilePaths.Example;


			/// Run.
			var projectElement = Instances.ProjectXmlOperator.CreateNew();

			Instances.ProjectXmlOperator.SetSdk(
				projectElement,
				F0020.ProjectSdkStrings.Instance.Web);

			Instances.ProjectXmlOperator.SetTargetFramework(
				projectElement,
				F0020.TargetFrameworkMonikerStrings.Instance.NET_6);

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
		public void CreateNewMinimalProject()
        {
			var projectElement = Instances.ProjectXmlOperator.CreateNew();

			Operations.Instance.OutputToFileAndOpen(projectElement);
        }
	}
}