// AudioElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[ScriptName("Element")]
	[Imported(ObeysTypeSystem = true)]
	public sealed class AudioElement : MediaElement {
		[InlineCode("new Audio({url})")]
		public AudioElement(string url) {
		}
	}
}