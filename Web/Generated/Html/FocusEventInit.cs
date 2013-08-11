﻿// FocusEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class FocusEventInit : UIEventInit {
		public EventTarget RelatedTarget {
			get { return default(EventTarget); }
			set { }
		}
	}
}
