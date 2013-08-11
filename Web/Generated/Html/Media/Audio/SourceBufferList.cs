﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SourceBufferList : EventTarget {
		internal SourceBufferList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SourceBuffer this[uint index] {
			get { return default(SourceBuffer); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SourceBuffer> GetEnumerator() {
			return default(IEnumerator<SourceBuffer>);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}