using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class TaskDialog : Form
	{
		public enum ActionType { New, Edit};
		public ActionType Action { get; set; } = ActionType.New;
		public Ukoly InstanceUkolu { get; set; }
		//Abychm změnili nebo vytvořili data obsažená v listu, vytvoříme pomocnou instanci. S tou pak budeme pracovat v rozdělení dialogu podle toho, jestli chceme data změnit, nebo zapsat nová.
		public TaskDialog()
		{
			InitializeComponent();
		}

		private void TaskDialog_VisibleChanged(object sender, EventArgs e)
			//Pro zobrazení stávajících dat v novém dialogu, aby se data zobrazovala tam, kde mají.
		{
			if (Action == ActionType.Edit)
			{
				txtNazevUkolu.Text = InstanceUkolu.NazevUkolu;
				//Vypíše druh úkolu podle zaškrtnutého checkboxu.
				if (cbxProgramovani.Checked)
				{
					InstanceUkolu.TypUkolu = "Programování";
				}
				else if (cbxMeeting.Checked)
				{
					InstanceUkolu.TypUkolu = "Meeting";
				}
				else if (cbxKafe.Checked)
				{
					InstanceUkolu.TypUkolu = "Kafe";
				}
				else
					InstanceUkolu.TypUkolu = "nezadáno";
				numDay.Value = InstanceUkolu.Den;
				numMonth.Value = InstanceUkolu.Mesic;
				numYear.Value = InstanceUkolu.Rok;
				numHour.Value = InstanceUkolu.Hodina;
				numMinute.Value = InstanceUkolu.Minuta;
			}
			else
			{
				txtNazevUkolu.Text = "";
				//Vypíše druh úkolu podle zaškrtnutého checkboxu.
				if (cbxProgramovani.Checked==true)
				{
					InstanceUkolu.TypUkolu = "Programování";
				}
				else if (cbxMeeting.Checked==true)
				{
					InstanceUkolu.TypUkolu = "Meeting";
				}
				else if (cbxKafe.Checked==true)
				{
					InstanceUkolu.TypUkolu = "Kafe";
				}
				numDay.Value = 1;
				numMonth.Value = 1;
				numYear.Value = 2021;
				numHour.Value = 0;
				numMinute.Value = 0;
			}
		}
		private void btnOK_Click(object sender, EventArgs e)
			//Rodělení, jestli dialogové okno vytváří nový záznam, nebo jestli jestli edituje stávající.
		{
			switch (Action)
			{
				case ActionType.New:
					InstanceUkolu = new Ukoly(txtNazevUkolu.Text, /*cbxProgramovani.Checked, cbxMeeting.Checked, cbxKafe.Checked,*/ InstanceUkolu.TypUkolu,(int)numDay.Value, (int)numMonth.Value, (int)numYear.Value, (int)numHour.Value, (int)numMinute.Value);
					break;
				case ActionType.Edit:
					InstanceUkolu.NazevUkolu = txtNazevUkolu.Text;
					InstanceUkolu.Den = (int)numDay.Value;
					InstanceUkolu.Mesic = (int)numMonth.Value;
					InstanceUkolu.Rok = (int)numYear.Value;
					InstanceUkolu.Hodina = (int)numHour.Value;
					InstanceUkolu.Minuta = (int)numMinute.Value;
					break;
			}
		}
	}
}
