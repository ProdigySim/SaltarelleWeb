﻿using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'METER'"), ScriptName("Element")]
	public partial class MeterElement : Element {
		internal MeterElement() {
		}

		[IntrinsicProperty]
		public double High {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Low {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Max {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Min {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Optimum {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Value {
			get { return 0; }
			set { }
		}
	}
}