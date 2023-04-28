using System;
using System.Collections.Generic;
using System.Xml.Linq;

using Microsoft.Extensions.Logging;

using R5T.F0020;
using R5T.T0132;
using R5T.T0159.Extensions;


namespace R5T.S0048
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
        public bool NoCheckEolTargetFrameworkElementOrTrue(string projectFilePath)
		{
            var isOfInterest = ProjectFileOperator.Instance.InQueryProjectFileContext_Synchronous(
                projectFilePath,
                this.NoCheckEolTargetFrameworkElementOrTrue);

            return isOfInterest;
        }

        public bool NoCheckEolTargetFrameworkElementOrTrue(XElement projectElement)
		{
            var hasTargetFramework = ProjectXmlOperator.Instance.HasTargetFramework(projectElement);
            if (!hasTargetFramework)
            {
                // Not sure what the project is (maybe old-style C# project), but ignore.
                return false;
            }

            var isNet5 = hasTargetFramework.Result == TargetFrameworkMonikerStrings.Instance.NET_5;
            if (!isNet5)
            {
                return false;
            }

            var hasCheckEol = ProjectXmlOperator.Instance.HasCheckEolTargetFrameworkElement(projectElement);
            if (hasCheckEol.IsNotFound())
            {
                // No EOL, that is of interest.
                return true;
            }

            var checkEolValue = F0000.BooleanOperator.Instance.From(hasCheckEol.Result.Value);
            if (!checkEolValue)
            {
                // If the check attribute is false, the project is ok (we want false).
                return false;
            }

            return true;
        }

        public IEnumerable<string> GetAllProjectFilePaths()
		{
			var projectFilePaths = F0035.LoggingOperator.Instance.InConsoleLoggerContext_Synchronous(
				nameof(GetAllProjectFilePaths),
				logger =>
				{
					var projectFilePaths = this.GetAllProjectFilePaths(
						logger)
						//// Evaluate now before the logger goes away?
						//// Seems to work, but keep here in case of future issues.
						//.Now();
						;

					return projectFilePaths;
				});

			return projectFilePaths;
        }

        public IEnumerable<string> GetAllProjectFilePaths(
			ILogger logger)
		{
			var output = F0082.FileSystemOperator.Instance.GetAllProjectFilePaths_FromRepositoriesDirectoryPaths(
				Z0022.RepositoriesDirectoryPaths.Instance.AllOfMine,
				logger.ToTextOutput());

			return output;
		}

		public void OutputToFileAndOpen(XElement projectElement)
        {
			var projectFilePath = Instances.ProjectFilePaths.Example;

			this.OutputToFileAndOpen(
				projectElement,
				projectFilePath);
		}

		public void OutputToFileAndOpen(XElement projectElement,
			string projectFilePath)
		{
			Instances.ProjectFileOperator.Save_Synchronous(
				projectFilePath,
				projectElement);

			Instances.NotepadPlusPlusOperator.Open(
				projectFilePath);
		}
	}
}