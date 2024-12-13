﻿using System.Drawing;
using System;
using TrueColorConsole;

namespace BildIntegration
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyIMG("TestBild.png");
		}

		internal static void MyIMG(string img_name) //hier wird der Name ünergeben zb. Bild.png
		{
			string gdir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
			gdir += @"\ressource\" + img_name;
			int res_x = 192;
			int res_y = 108;

	
			Bitmap image = new Bitmap(new Bitmap(gdir), new Size(res_x, res_y));
			//Für res_x habe ich ein Feld mit int 240 und bei res_y ein int mit 100. Für die Bilder sollten ebenfalls die DIMENSIONEN 240px x 100px haben

			VTConsole.Enable();

			for (int y = 0; y <= res_y - 1; y = y + 2)
			{
				for (int x = 0; x <= res_x - 1; x++)
				{
					Color color = image.GetPixel(x, y);

					VTConsole.Write(((char)'\u2588').ToString(), Color.FromArgb(color.R, color.G, color.B));
					//Achtung hier wird die Nuget Bibliothek True Color Console

					
					Console.ForegroundColor = ConsoleColor.White;
				}
                Console.WriteLine();

                VTConsole.Disable();




			}
		}
	}

	

}
