// DocumentFragment.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[Imported]
	public class DocumentFragment {
		internal DocumentFragment() {
		}

		public Element AppendChild(Element child) {
			return null;
		}

		[IntrinsicProperty]
		public ElementAttributeCollection Attributes {
			get { return null; }
		}

		[IntrinsicProperty]
		public ElementCollection ChildNodes {
			get { return null; }
		}

		public DocumentFragment CloneNode() {
			return null;
		}

		public Element CloneNode(bool deep) {
			return null;
		}

		public bool Contains(Element element) {
			return false;
		}

		[IntrinsicProperty]
		public Element FirstChild {
			get { return null; }
		}

		public Element GetElementById(string id) {
			return null;
		}

		public ElementCollection GetElementsByTagName(string tagName) {
			return null;
		}

		public bool HasAttributes() {
			return false;
		}

		public bool HasChildNodes() {
			return false;
		}

		public Element InsertBefore(Element newChild) {
			return null;
		}

		public Element InsertBefore(Element newChild, Element referenceChild) {
			return null;
		}

		[IntrinsicProperty]
		public Element LastChild {
			get { return null; }
		}

		[IntrinsicProperty]
		public Element NextSibling {
			get { return null; }
		}

		[IntrinsicProperty]
		public string NodeName {
			get { return null; }
		}

		[IntrinsicProperty]
		public int NodeType {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string NodeValue {
			get { return null; }
		}

		[IntrinsicProperty]
		public DocumentInstance OwnerDocument {
			get { return null; }
		}

		[IntrinsicProperty]
		public Element ParentNode {
			get { return null; }
		}

		[IntrinsicProperty]
		public Element PreviousSibling {
			get { return null; }
		}

		public Element RemoveChild(Element child) {
			return null;
		}

		public Element ReplaceChild(Element newChild, Element oldChild) {
			return null;
		}
	}
}