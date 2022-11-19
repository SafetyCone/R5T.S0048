using System;

using R5T.F0020;
using R5T.F0033;
using R5T.Z0019;


namespace R5T.S0048
{
    public static class Instances
    {
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator { get; } = F0033.NotepadPlusPlusOperator.Instance;
        public static IProjectFileOperator ProjectFileOperator { get; } = F0020.ProjectFileOperator.Instance;
        public static IProjectFilePaths ProjectFilePaths { get; } = Z0019.ProjectFilePaths.Instance;
        public static IProjectXmlOperator ProjectXmlOperator { get; } = F0020.ProjectXmlOperator.Instance;
    }
}