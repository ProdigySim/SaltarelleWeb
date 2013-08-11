// XmlNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace]
	[Imported]
	public class XmlNode {
		internal XmlNode() {
		}

		public XmlNode AppendChild(XmlNode child) {
			return null;
		}

		[IntrinsicProperty]
		public XmlNamedNodeMap Attributes {
			get { return null; }
		}

		[IntrinsicProperty]
		public string BaseName {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNodeList ChildNodes {
			get { return null; }
		}

		public XmlNode CloneNode(bool deepClone) {
			return null;
		}

		[IntrinsicProperty]
		public XmlNode FirstChild {
			get { return null; }
		}

		public XmlNodeList GetElementsByTagName(string tagName) {
			return null;
		}

		public bool HasChildNodes() {
			return false;
		}

		[IntrinsicProperty]
		[ScriptName("text")]
		public string InnerText {
			get { return null; }
		}

		public XmlNode InsertBefore(XmlNode child, XmlNode refChild) {
			return null;
		}

		[IntrinsicProperty]
		public XmlNode LastChild {
			get { return null; }
		}

		[IntrinsicProperty]
		[ScriptName("nodeName")]
		public string Name {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNode NextSibling {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNodeType NodeType {
			get { return 0; }
		}

		[IntrinsicProperty]
		[ScriptName("xml")]
		public string OuterXml {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlDocument OwnerDocument {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNode ParentNode {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Prefix {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNode PreviousSibling {
			get { return null; }
		}

		public XmlNode RemoveChild(XmlNode child) {
			return null;
		}

		public XmlNode ReplaceChild(XmlNode child, XmlNode oldChild) {
			return null;
		}

		public XmlNodeList SelectNodes(string xpath) {
			return null;
		}

		public XmlNode SelectSingleNode(string xpath) {
			return null;
		}

		public string TransformNode(XmlDocument stylesheet) {
			return null;
		}

		[IntrinsicProperty]
		[ScriptName("nodeValue")]
		public string Value {
			get { return null; }
			set { }
		}
	}
}