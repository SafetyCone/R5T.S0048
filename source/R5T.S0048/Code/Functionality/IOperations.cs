using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.S0048
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
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