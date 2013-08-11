// IElementEventHandler.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported]
	public interface IElementEventHandler {
		void HandleEvent(ElementEvent e);
	}
}