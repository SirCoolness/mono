//
// System.ComponentModel.ITypeDescriptorContext
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) 2002 Ximian, Inc (http://www.ximian.com)
//

using System;

namespace System.ComponentModel
{

public interface ITypeDescriptorContext : IServiceProvider
{
	IContainer Container { get; }

	object Instance { get; }

	PropertyDescriptor PropertyDescriptor { get; }

	void OnComponentChanged ();

	void OnComponentChanging ();
}

}

