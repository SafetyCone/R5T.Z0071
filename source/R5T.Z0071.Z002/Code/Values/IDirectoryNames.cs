using System;

using R5T.T0131;


namespace R5T.Z0071.Z002
{
    /// <summary>
    /// Contextually-named, derived, stringly-typed directory names
    /// (of common-opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z000.IDirectoryNames _Raw => Z000.DirectoryNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The name for the front-end source code files directory in a web project.
        /// The source directory contains all front-end source code files (CSS, JavaScript, etc.) to separate them from other web project related files (like server-side C# code files).
        /// <para><inheritdoc cref="Z000.IDirectoryNames.source" path="descendant::value"/></para>
        /// Lowercase "source" for front-end source code files directory.
        /// </summary>
        public string FrontEnd_Source_DirectoryName => _Raw.source;

        /// <summary>
        /// The name for the source child directory in a repository directory.
        /// The source directory contains all source code files to separate them from other repository-related files (e.g. the .gitignore file).
        /// <para><inheritdoc cref="Z000.IDirectoryNames.source" path="descendant::value"/></para>
        /// Lowercase "source" for repository directory.
        /// </summary>
        public string Repository_Source_DirectoryName => _Raw.source;
    }
}
