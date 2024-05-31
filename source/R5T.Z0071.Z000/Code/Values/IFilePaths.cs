using System;

using R5T.T0131;


namespace R5T.Z0071.Z000
{
    /// <summary>
    /// Absolutely-named (raw), fundamental, stringly-typed, file paths
    /// (of common-opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        /// <summary>
        /// <para><value>C:\Temp\Output.txt</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0063.Z000.IFilePaths.C_Temp_Output_txt")]
        public string C_Temp_Output_txt => @"C:\Temp\Output.txt";
    }
}
