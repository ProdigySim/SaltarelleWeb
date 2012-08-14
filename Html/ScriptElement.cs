// ScriptElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {
    [IgnoreNamespace]
	[ScriptName("Element")]
    [Imported(IsRealType = true)]
    public sealed class ScriptElement : Element {

        private ScriptElement() {
        }

        [IntrinsicProperty]
        public string Src {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public string Type {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public string ReadyState {
            get {
                return null;
            }
            set {
            }
        }
    }
}
