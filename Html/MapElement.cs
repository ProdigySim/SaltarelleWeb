// MapElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {
    [IgnoreNamespace]
	[ScriptName("Element")]
    [Imported(IsRealType = true)]
    public sealed class MapElement : Element {

        private MapElement() {
        }

        [IntrinsicProperty]
        public string Name {
            get {
                return null;
            }
            set {
            }
        }
    }
}
