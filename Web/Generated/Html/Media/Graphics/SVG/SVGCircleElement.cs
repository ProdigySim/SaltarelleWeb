﻿// SVGCircleElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGCircleElement : SVGGraphicsElement {
		internal SVGCircleElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Cx {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Cy {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength R {
			get { return default(SVGAnimatedLength); }
		}
	}
}
