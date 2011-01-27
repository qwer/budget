using System;
using System.Reflection;
using System.ComponentModel;

using Microsoft.Practices.Unity;
using System.Linq;

namespace Budget.App.IoC
{
	public interface IResolve
	{
		I Resolve<I>();
	}

	public interface IRegister
	{
		void Register<T>(T t);
		void Register<I, T>() where T : I;
	}

	public interface IContainer : IResolve, IRegister
	{
		void Inject<T>(T t);
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

		public void Register<T>(T t)
		{
			container.RegisterInstance(t);
		}

		public void Inject<T>(T t)
		{
			foreach (PropertyInfo pi in t.GetType().GetProperties())
				if (pi.GetCustomAttributes(typeof(DependencyAttribute), true).Length > 0)
					pi.SetValue(t, container.Resolve(pi.PropertyType), null);
		}
	}

	static class IoCContainer
	{
		private static readonly IContainer container = new MsUnityContainer();
		public static IContainer Instance
		{
			get { return container; }
		}
	}

	[AttributeUsage(
		AttributeTargets.Property, 
		Inherited = false, 
		AllowMultiple = false)]
	class DependencyAttribute : Attribute
	{
	} 
}
