using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0048
{
	[FunctionalityMarker]
	public partial interface IProjectFileOperations : IFunctionalityMarker,
		F0081.IProjectFileOperations
	{
		/// <inheritdoc cref="F0081.IProjectFileOperations.Resolve_NETSDK1138_TargetFrameworkOutOfSupportWarning_NoCheck(string)"/>
		public async Task Resolve_NETSDK1138_TargetFrameworkOutOfSupportWarning_NoCheck()
		{
			/// Inputs.
			var projectFilePaths = new[]
			{
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0040\source\R5T.T0040\R5T.T0040.csproj",
            };


			/// Run.
			foreach (var projectFilePath in projectFilePaths)
			{
				await this.Resolve_NETSDK1138_TargetFrameworkOutOfSupportWarning_NoCheck(
					projectFilePath);
			}
		}
	}
}