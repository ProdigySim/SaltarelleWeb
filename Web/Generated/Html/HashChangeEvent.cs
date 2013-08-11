﻿using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class HashChangeEvent : Event {
		internal HashChangeEvent() {
		}

		public HashChangeEvent(string type) {
		}

		public HashChangeEvent(string type, HashChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public string NewURL {
			get { return null; }
		}

		[IntrinsicProperty]
		public string OldURL {
			get { return null; }
		}
	}
}
