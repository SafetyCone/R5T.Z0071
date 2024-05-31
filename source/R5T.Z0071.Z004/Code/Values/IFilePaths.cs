using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0071.Z004
{
    /// <summary>
    /// Conceptually named, derived, leaf strong-typed file paths
    /// (of common opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z001.IFilePaths _Raw => Z001.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z001.IFilePaths.C_Temp_Output_txt"/>
        [Obsolete("See R5T.Z0071.Z003.IFilePaths.C_Temp_Output_txt")]
        public IFilePath Output_Text_FilePath => _Raw.C_Temp_Output_txt;
    }
}
