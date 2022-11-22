using System;


namespace R5T.S0048
{
	public class ProjectFileScripts : IProjectFileScripts
	{
		#region Infrastructure

	    public static IProjectFileScripts Instance { get; } = new ProjectFileScripts();

	    private ProjectFileScripts()
	    {
        }

	    #endregion
	}
}