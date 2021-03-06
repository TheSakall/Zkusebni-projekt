
namespace WindowsFormsApp1
{
	partial class TaskDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNazevUkolu = new System.Windows.Forms.TextBox();
			this.cbxProgramovani = new System.Windows.Forms.CheckBox();
			this.cbxMeeting = new System.Windows.Forms.CheckBox();
			this.cbxKafe = new System.Windows.Forms.CheckBox();
			this.numDay = new System.Windows.Forms.NumericUpDown();
			this.numMonth = new System.Windows.Forms.NumericUpDown();
			this.numYear = new System.Windows.Forms.NumericUpDown();
			this.numHour = new System.Windows.Forms.NumericUpDown();
			this.numMinute = new System.Windows.Forms.NumericUpDown();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNazevUkolu
			// 
			this.txtNazevUkolu.Location = new System.Drawing.Point(104, 52);
			this.txtNazevUkolu.Name = "txtNazevUkolu";
			this.txtNazevUkolu.Size = new System.Drawing.Size(305, 20);
			this.txtNazevUkolu.TabIndex = 0;
			// 
			// cbxProgramovani
			// 
			this.cbxProgramovani.AutoSize = true;
			this.cbxProgramovani.Location = new System.Drawing.Point(104, 95);
			this.cbxProgramovani.Name = "cbxProgramovani";
			this.cbxProgramovani.Size = new System.Drawing.Size(93, 17);
			this.cbxProgramovani.TabIndex = 1;
			this.cbxProgramovani.Text = "Programování";
			this.cbxProgramovani.UseVisualStyleBackColor = true;
			// 
			// cbxMeeting
			// 
			this.cbxMeeting.AutoSize = true;
			this.cbxMeeting.Location = new System.Drawing.Point(216, 95);
			this.cbxMeeting.Name = "cbxMeeting";
			this.cbxMeeting.Size = new System.Drawing.Size(64, 17);
			this.cbxMeeting.TabIndex = 2;
			this.cbxMeeting.Text = "Meeting";
			this.cbxMeeting.UseVisualStyleBackColor = true;
			// 
			// cbxKafe
			// 
			this.cbxKafe.AutoSize = true;
			this.cbxKafe.Location = new System.Drawing.Point(303, 95);
			this.cbxKafe.Name = "cbxKafe";
			this.cbxKafe.Size = new System.Drawing.Size(83, 17);
			this.cbxKafe.TabIndex = 3;
			this.cbxKafe.Text = "Čas na kafe";
			this.cbxKafe.UseVisualStyleBackColor = true;
			// 
			// numDay
			// 
			this.numDay.Location = new System.Drawing.Point(104, 138);
			this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numDay.Name = "numDay";
			this.numDay.Size = new System.Drawing.Size(50, 20);
			this.numDay.TabIndex = 4;
			this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numMonth
			// 
			this.numMonth.Location = new System.Drawing.Point(160, 138);
			this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMonth.Name = "numMonth";
			this.numMonth.Size = new System.Drawing.Size(50, 20);
			this.numMonth.TabIndex = 5;
			this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numYear
			// 
			this.numYear.Location = new System.Drawing.Point(216, 138);
			this.numYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
			this.numYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
			this.numYear.Name = "numYear";
			this.numYear.Size = new System.Drawing.Size(50, 20);
			this.numYear.TabIndex = 6;
			this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
			// 
			// numHour
			// 
			this.numHour.Location = new System.Drawing.Point(303, 138);
			this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numHour.Name = "numHour";
			this.numHour.Size = new System.Drawing.Size(50, 20);
			this.numHour.TabIndex = 7;
			// 
			// numMinute
			// 
			this.numMinute.Location = new System.Drawing.Point(359, 138);
			this.numMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numMinute.Name = "numMinute";
			this.numMinute.Size = new System.Drawing.Size(50, 20);
			this.numMinute.TabIndex = 8;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(12, 200);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(334, 200);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Zrušit";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Datum a čas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Název úkolu:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Druh úkolu:";
			// 
			// TaskDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 297);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.numMinute);
			this.Controls.Add(this.numHour);
			this.Controls.Add(this.numYear);
			this.Controls.Add(this.numMonth);
			this.Controls.Add(this.numDay);
			this.Controls.Add(this.cbxKafe);
			this.Controls.Add(this.cbxMeeting);
			this.Controls.Add(this.cbxProgramovani);
			this.Controls.Add(this.txtNazevUkolu);
			this.Name = "TaskDialog";
			this.Text = "TaskDialog";
			this.VisibleChanged += new System.EventHandler(this.TaskDialog_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNazevUkolu;
		private System.Windows.Forms.CheckBox cbxProgramovani;
		private System.Windows.Forms.CheckBox cbxMeeting;
		private System.Windows.Forms.CheckBox cbxKafe;
		private System.Windows.Forms.NumericUpDown numDay;
		private System.Windows.Forms.NumericUpDown numMonth;
		private System.Windows.Forms.NumericUpDown numYear;
		private System.Windows.Forms.NumericUpDown numHour;
		private System.Windows.Forms.NumericUpDown numMinute;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}