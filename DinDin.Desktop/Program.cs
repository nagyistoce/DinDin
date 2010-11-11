using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Castle.Core;
using Castle.MicroKernel;

using DinDin.Core.Interfaces;
using DinDin.Core.Services;
using DinDin.Repository.Native;

namespace DinDin.Desktop
{
	static class Program
	{
		private readonly static IKernel container = InitializeContainer();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		private static IKernel InitializeContainer()
		{
			IKernel container = new DefaultKernel();
			container.AddComponentInstance<AccountRepository>(
				typeof(IAccountRepository),
				new AccountRepository(
					Path.Combine(
						Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
						"DinDin")));
			container.AddComponent<AccountServices>(typeof(IAccountServices), LifestyleType.Singleton, true);
			return container;
		}

		internal static I GetService<I>()
		{
			return container.Resolve<I>();
		}
	}
}