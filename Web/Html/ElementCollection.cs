// ElementCollection.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[Imported]
	public sealed class ElementCollection {
		internal ElementCollection() {
		}

		[EnumerateAsArray]
		[InlineCode("new {$System.ArrayEnumerator}({this})")]
		public ArrayEnumerator<Element> GetEnumerator() {
			return null;
		}

		[IntrinsicProperty]
		public Element this[int index] {
			get { return null; }
		}

		[IntrinsicProperty]
		public int Length {
			get { return 0; }
		}
	}
}