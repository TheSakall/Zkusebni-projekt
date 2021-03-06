using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
	public static class Databaze
		//Databáze dat, která bude naházená v listu.
	{
		public static BindingList<Ukoly> SeznamUkolu = new BindingList<Ukoly>();
		static Databaze()
		{
			Deserializuj();
		}
		//Ukládání a načítání dat pomocí procesu Serializace/Deserializace
		//Serializace bude prováděna skrze Datový proud, který bude probíhat vždy při ukončení souboru.
		//Deserializace poté bude probíhat vždy při otevření souboru.
		public static void Serializuj()
		{
			using (Stream s = File.Open("Ukoly.bin",FileMode.Create))
			{
				BinaryFormatter bin = new BinaryFormatter();
				bin.Serialize(s, SeznamUkolu);
			}
		}
		public static void Deserializuj()
		{
			using (Stream s = File.Open("Ukoly.bin", FileMode.Open))
			{
				BinaryFormatter bin = new BinaryFormatter();
				SeznamUkolu = (BindingList<Ukoly>)bin.Deserialize(s);
			}
		}
	}
}
