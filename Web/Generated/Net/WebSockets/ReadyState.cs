﻿using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[Imported]
	public enum ReadyState {
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3,
	}
}
