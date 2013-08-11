﻿// PanningModelType.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[NamedValues]
	[IgnoreNamespace, Imported]
	public enum PanningModelType {
		[ScriptName("equalpower")] EqualPower,

		[ScriptName("HRTF")] HRTF,

		[ScriptName("soundfield")] SoundField
	}
}