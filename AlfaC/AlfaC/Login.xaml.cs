﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AlfaC
{
	/// <summary>
	/// Lógica de interacción para Login.xaml
	/// </summary>
	public partial class Login : Window
	{
		public Login()
		{
			SplashScreen sp = new SplashScreen("Splash.png");
			sp.Show(true);
			this.InitializeComponent();
			
			
			// A partir de este punto se requiere la inserción de código para la creación del objeto.
		}
	}
}