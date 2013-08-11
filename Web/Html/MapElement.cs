// MapElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[ScriptName("Element")]
	[Imported(ObeysTypeSystem = true)]
	public sealed class MapElement : Element {
		private MapElement() {
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
			set { }
		}
	}
}