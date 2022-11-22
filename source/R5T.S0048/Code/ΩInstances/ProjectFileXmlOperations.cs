using System;


namespace R5T.S0048
{
	public class ProjectFileXmlOperations : IProjectFileXmlOperations
	{
		#region Infrastructure

	    public static IProjectFileXmlOperations Instance { get; } = new ProjectFileXmlOperations();

	    private ProjectFileXmlOperations()
	    {
        }

	    #endregion
	}
}