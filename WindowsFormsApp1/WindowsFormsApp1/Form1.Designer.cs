
namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Vyžaduje se proměnná návrháře.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Uvolněte všechny používané prostředky.
		/// </summary>
		/// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kód generovaný Návrhářem Windows Form

		/// <summary>
		/// Metoda vyžadovaná pro podporu Návrháře - neupravovat
		/// obsah této metody v editoru kódu.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvTaskList = new System.Windows.Forms.DataGridView();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPridatUkol = new System.Windows.Forms.Button();
			this.btnEditUkol = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTaskList
			// 
			this.dgvTaskList.AllowUserToOrderColumns = true;
			this.dgvTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dgvTaskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTaskList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTaskList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvTaskList.Location = new System.Drawing.Point(194, 116);
			this.dgvTaskList.MultiSelect = false;
			this.dgvTaskList.Name = "dgvTaskList";
			this.dgvTaskList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTaskList.Size = new System.Drawing.Size(374, 150);
			this.dgvTaskList.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(446, 272);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(122, 37);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Ukončit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPridatUkol
			// 
			this.btnPridatUkol.Location = new System.Drawing.Point(54, 116);
			this.btnPridatUkol.Name = "btnPridatUkol";
			this.btnPridatUkol.Size = new System.Drawing.Size(122, 37);
			this.btnPridatUkol.TabIndex = 2;
			this.btnPridatUkol.Text = "Přidat úkol";
			this.btnPridatUkol.UseVisualStyleBackColor = true;
			this.btnPridatUkol.Click += new System.EventHandler(this.btnPridatUkol_Click);
			// 
			// btnEditUkol
			// 
			this.btnEditUkol.Location = new System.Drawing.Point(54, 159);
			this.btnEditUkol.Name = "btnEditUkol";
			this.btnEditUkol.Size = new System.Drawing.Size(122, 37);
			this.btnEditUkol.TabIndex = 3;
			this.btnEditUkol.Text = "Editovat úkol";
			this.btnEditUkol.UseVisualStyleBackColor = true;
			this.btnEditUkol.Click += new System.EventHandler(this.btnEditUkol_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(54, 202);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(122, 37);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Smazat úkol";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(194, 90);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(293, 20);
			this.searchBox.TabIndex = 5;
			this.searchBox.Text = "Co chcete hledat ?";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(493, 88);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Hledat";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 321);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEditUkol);
			this.Controls.Add(this.btnPridatUkol);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.dgvTaskList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTaskList;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnPridatUkol;
		private System.Windows.Forms.Button btnEditUkol;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Button btnSearch;
	}
}

