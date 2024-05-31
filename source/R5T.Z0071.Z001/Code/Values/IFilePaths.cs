using System;

using R5T.T0131;
using R5T.T0252;
using R5T.T0252.Extensions;


namespace R5T.Z0071.Z001
{
    /// <summary>
    /// Absolutely-named (raw), fundamental (for the strong type, derived for the system-type), strong-typed, file paths
    /// (of common-opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z000.IFilePaths _Strings => Z000.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z000.IFilePaths.C_Temp_Output_txt"/>
        [Obsolete("See R5T.Z0063.Z001.IFilePaths.C_Temp_Output_txt")]
        public IFilePath C_Temp_Output_txt => _Strings.C_Temp_Output_txt.ToFilePath();
    }
}
