﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SELECT'"), ScriptName("Element")]
	public partial class SelectElement : Element {
		internal SelectElement() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public TypeOption<XmlElement, OptionElement> this[uint index] {
			get { return default(TypeOption<XmlElement, OptionElement>); }
			set { }
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element) {
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before) {
		}

		[IntrinsicProperty]
		public bool Autofocus {
			get { return false; }
			set { }
		}

		public bool CheckValidity() {
			return false;
		}

		[IntrinsicProperty]
		public bool Disabled {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public FormElement Form {
			get { return default(FormElement); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlElement> GetEnumerator() {
			return default(IEnumerator<XmlElement>);
		}

		public XmlElement Item(uint index) {
			return default(XmlElement);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool Multiple {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
			set { }
		}

		public OptionElement NamedItem(string name) {
			return default(OptionElement);
		}

		[IntrinsicProperty]
		public HtmlOptionsCollection Options {
			get { return default(HtmlOptionsCollection); }
		}

		public void Remove() {
		}

		public void Remove(int index) {
		}

		[IntrinsicProperty]
		public bool Required {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public int SelectedIndex {
			get { return 0; }
			set { }
		}

		public void SetCustomValidity(string error) {
		}

		[IntrinsicProperty]
		public uint Size {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
		}

		[IntrinsicProperty]
		public string ValidationMessage {
			get { return null; }
		}

		[IntrinsicProperty]
		public ValidityState Validity {
			get { return default(ValidityState); }
		}

		[IntrinsicProperty]
		public string Value {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public bool WillValidate {
			get { return false; }
		}
	}
}