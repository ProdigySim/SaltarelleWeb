// DropEffects.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    [NamedValues]
    public enum AllowedDropEffect {

        Copy = 0,

        Link = 1,

        Move = 2,

        CopyLink = 3,

        CopyMove = 4,

        LinkMove = 5,

        All = 6,

        None = 7
    }
}
