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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			dgvTaskList.DataSource = Databaze.SeznamUkolu;
		}
		TaskDialog taskDialog = new TaskDialog();
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnPridatUkol_Click(object sender, EventArgs e)
		{
			taskDialog.Action = TaskDialog.ActionType.New;
			if (taskDialog.ShowDialog()==DialogResult.OK)
			{
				Databaze.SeznamUkolu.Add(taskDialog.InstanceUkolu);
			}
		}

		private void btnEditUkol_Click(object sender, EventArgs e)
		{
			taskDialog.Action = TaskDialog.ActionType.Edit;
			taskDialog.InstanceUkolu = (Ukoly)dgvTaskList.CurrentRow.DataBoundItem;
			taskDialog.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{			
			int indU = dgvTaskList.CurrentCell.RowIndex;
			Databaze.SeznamUkolu.RemoveAt(indU);
			btnDelete.Enabled = (Databaze.SeznamUkolu.Count > 0);
			//Smazání záznamu v úkolech podle indexu + zneplatnění tlačítka, pokud seznam neobsahuje žádná data.
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Databaze.Serializuj();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = dgvTaskList.DataSource;
			bs.Filter = "NazevUkolu  like '%" + searchBox.Text + "%'";
			dgvTaskList.DataSource = bs;
		}
	}
}
