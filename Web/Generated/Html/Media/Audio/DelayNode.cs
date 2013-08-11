﻿using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DelayNode : AudioNode {
		internal DelayNode() {
		}

		[IntrinsicProperty]
		public AudioParam DelayTime {
			get { return default(AudioParam); }
		}
	}
}
