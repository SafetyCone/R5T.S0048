using System;


namespace R5T.S0048
{
	public class ProjectFileOperations : IProjectFileOperations
	{
		#region Infrastructure

	    public static IProjectFileOperations Instance { get; } = new ProjectFileOperations();

	    private ProjectFileOperations()
	    {
        }

	    #endregion
	}
}