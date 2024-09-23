using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0071
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z001.IDirectoryNames _Raw => Z001.DirectoryNames.Instance;

        [Ignore]
        public Z002.IDirectoryNames _Strings => Z002.DirectoryNames.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
