﻿using aru_software_eng_UI;
using System;
using System.Windows.Forms;

/*The only class functions that you are allowed to run in
the windows are the ones directly from the UIBackendInterface
instance created here.*/

public class Program
{
	static void Main(string[] args)
	{
		Application.Run(new StartMenu(new BackendController(new DatabaseHandler(new UserDatabaseDataSet()))));
	}
}