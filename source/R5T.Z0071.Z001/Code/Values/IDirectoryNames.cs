using System;

using R5T.T0131;
using R5T.T0245;
using R5T.T0245.Extensions;


namespace R5T.Z0071.Z001
{
    /// <summary>
    /// Absolutely named, fundamental, leaf strong-typed directory names
    /// (of common opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z000.IDirectoryNames _Strings => Z000.DirectoryNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles
        /// <inheritdoc cref="Z000.IDirectoryNames.source"/>
        public IDirectoryName source => _Strings.source.ToDirectoryName();
#pragma warning restore IDE1006 // Naming Styles
    }
}
