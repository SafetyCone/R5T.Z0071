using System;

using R5T.T0131;


namespace R5T.Z0071.Z000
{
    /// <summary>
    /// Absolutely-named (raw), fundamental, stringly-typed, directory names
    /// (of common-opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>css</value></para>
        /// </summary>
        public string css => "css";

        /// <summary>
        /// <para><value>publish</value></para>
        /// </summary>
        public string publish => "publish";

        /// <summary>
        /// <para><value>source</value></para>
        /// </summary>
        public string source => "source";

#pragma warning restore IDE1006 // Naming Styles
    }
}
