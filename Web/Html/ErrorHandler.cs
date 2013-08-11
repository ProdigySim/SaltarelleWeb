// ErrorHandler.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

namespace System.Html {
	/// <summary>
	/// Delegate for the window unhandled exception handler.
	/// </summary>
	/// <param name="message">The error message.</param>
	/// <param name="url">The URL of the script where the error occurred.</param>
	/// <param name="line">The line number where the error occurred.</param>
	/// <returns>true if the error was handled; false otherwise.</returns>
	public delegate bool ErrorHandler(string message, string url, int line);
}