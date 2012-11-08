// ImageElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {
    [IgnoreNamespace]
	[ScriptName("Element")]
    [Imported(ObeysTypeSystem = true)]
    public sealed class ImageElement : Element {

        [InlineCode("new Image()")]
		public ImageElement() {
        }

        [InlineCode("new Image({width})")]
        public ImageElement(int width) {
        }

        [InlineCode("new Image({width}, {height})")]
        public ImageElement(int width, int height) {
        }

        [IntrinsicProperty]
        public string Alt {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public bool Complete {
            get {
                return false;
            }
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
        public int Height {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int NaturalHeight {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int NaturalWidth {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int Width {
            get {
                return 0;
            }
            set {
            }
        }
    }
}
