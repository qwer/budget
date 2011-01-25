using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Unity;

namespace Budget.App.IoC
{
	public interface IResolve
	{
		I Resolve<I>();
	}

	public interface IRegister
	{
		void Register<I, T>() where T : I;
	}

	public interface IContainer : IResolve, IRegister
	{
	}

	class MsUnityContainer : IContainer
	{
		IUnityContainer container = new UnityContainer();

		public MsUnityContainer()
		{
		}

		public I Resolve<I>()
		{
 			return container.Resolve<I>();
		}

		public void Register<I, T>() where T : I
		{
 			container.RegisterType<I, T>();
		}
	}
}
