// Selection.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Editing {
	/// <summary>
	/// Represents the active selection, which is a highlighted block of text, and/or other elements in the document on which a user or a script
	/// can carry out some action.
	/// </summary>
	[IgnoreNamespace]
	[Imported]
	public sealed class Selection {
		private Selection() {
		}

		public void Clear() {
		}

		public Range CreateRange() {
			return null;
		}

		public void Empty() {
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
		}
	}
}