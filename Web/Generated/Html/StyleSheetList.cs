﻿// StyleSheetList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheetList {
		internal StyleSheetList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public StyleSheet this[uint index] {
			get { return default(StyleSheet); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<StyleSheet> GetEnumerator() {
			return default(IEnumerator<StyleSheet>);
		}

		public StyleSheet Item(uint index) {
			return default(StyleSheet);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
