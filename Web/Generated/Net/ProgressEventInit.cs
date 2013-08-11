﻿using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, Serializable]
	public partial class ProgressEventInit : EventInit {
		public bool LengthComputable {
			get { return false; }
			set { }
		}

		public ulong Loaded {
			get { return 0; }
			set { }
		}

		public ulong Total {
			get { return 0; }
			set { }
		}
	}
}
