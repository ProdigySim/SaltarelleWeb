// PluginArray.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[Imported]
	public sealed class PluginArray {
		private PluginArray() {
		}

		/// <summary>
		/// Returns the Plugin at the specified index into the array.
		/// </summary>
		[IntrinsicProperty]
		public Plugin this[int index] {
			get { return null; }
		}

		/// <summary>
		/// Returns the Plugin with the specified name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		[IntrinsicProperty]
		public Plugin this[string name] {
			get { return null; }
		}

		/// <summary>
		/// Returns the Plugin at the specified index into the array.
		/// </summary>
		[ScriptName("item")]
		public Plugin ItemAt(int index) {
			return null;
		}

		/// <summary>
		/// The number of plugins in the array.
		/// </summary>
		[IntrinsicProperty]
		public long Length {
			get { return 0; }
		}

		/// <summary>
		/// Returns the Plugin with the specified name.
		/// </summary>
		public Plugin NamedItem(string name) {
			return null;
		}
	}
}