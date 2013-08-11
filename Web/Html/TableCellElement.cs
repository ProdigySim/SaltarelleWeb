// TableCellElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[ScriptName("Element")]
	[Imported(ObeysTypeSystem = true)]
	public sealed class TableCellElement : Element {
		private TableCellElement() {
		}

		[IntrinsicProperty]
		public int CellIndex {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public int ColSpan {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool NoWrap {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public int RowSpan {
			get { return 0; }
			set { }
		}
	}
}