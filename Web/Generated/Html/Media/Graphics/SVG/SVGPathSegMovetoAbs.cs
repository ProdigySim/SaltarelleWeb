﻿// SVGPathSegMovetoAbs.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathSegMovetoAbs : SVGPathSeg {
		internal SVGPathSegMovetoAbs() {
		}

		[IntrinsicProperty]
		public float X {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public float Y {
			get { return 0; }
			set { }
		}
	}
}
