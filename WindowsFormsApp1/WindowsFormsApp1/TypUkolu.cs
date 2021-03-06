using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class TypUkolu
	{
		public bool Programovani { get; set; }
		public bool Meeting { get; set; }
		public bool CasNaKafe { get; set; }

		public TypUkolu(bool programovani, bool meeting, bool casNaKafe)
		{
			Programovani = programovani;
			Meeting = meeting;
			CasNaKafe = casNaKafe;
		}
	}
}
