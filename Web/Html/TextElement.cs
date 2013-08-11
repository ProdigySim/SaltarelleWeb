// TextElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[ScriptName("Element")]
	[Imported(ObeysTypeSystem = true)]
	public class TextElement : InputElement {
		internal TextElement() {
		}

		[IntrinsicProperty]
		public int MaxLength {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool ReadOnly {
			get { return false; }
			set { }
		}
	}
}