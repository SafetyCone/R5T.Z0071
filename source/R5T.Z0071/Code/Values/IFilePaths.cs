using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0071
{
    /// <summary>
    /// File paths
    /// (of common opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker,
        Z004.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z002.IFilePaths _Strings => Z002.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
