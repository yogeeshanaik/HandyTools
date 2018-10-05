using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestNotifyWindow
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownHeight;
		private System.Windows.Forms.NumericUpDown numericUpDownWidth;
		private System.Windows.Forms.CheckBox checkBoxTitle;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxText = new System.Windows.Forms.TextBox();
			this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxTitle = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 128);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "Test";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(16, 16);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(232, 20);
			this.textBoxTitle.TabIndex = 1;
			this.textBoxTitle.Text = "Title Text";
			// 
			// textBoxText
			// 
			this.textBoxText.Location = new System.Drawing.Point(16, 64);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(232, 20);
			this.textBoxText.TabIndex = 2;
			this.textBoxText.Text = "This is the body of text to be displayed";
			// 
			// numericUpDownHeight
			// 
			this.numericUpDownHeight.Location = new System.Drawing.Point(160, 96);
			this.numericUpDownHeight.Maximum = new System.Decimal(new int[] {
																				2000,
																				0,
																				0,
																				0});
			this.numericUpDownHeight.Name = "numericUpDownHeight";
			this.numericUpDownHeight.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownHeight.TabIndex = 4;
			this.numericUpDownHeight.Value = new System.Decimal(new int[] {
																			  110,
																			  0,
																			  0,
																			  0});
			// 
			// numericUpDownWidth
			// 
			this.numericUpDownWidth.Location = new System.Drawing.Point(56, 96);
			this.numericUpDownWidth.Maximum = new System.Decimal(new int[] {
																			   2000,
																			   0,
																			   0,
																			   0});
			this.numericUpDownWidth.Name = "numericUpDownWidth";
			this.numericUpDownWidth.Size = new System.Drawing.Size(48, 20);
			this.numericUpDownWidth.TabIndex = 3;
			this.numericUpDownWidth.Value = new System.Decimal(new int[] {
																			 130,
																			 0,
																			 0,
																			 0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Width";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(120, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Height";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxTitle
			// 
			this.checkBoxTitle.Checked = true;
			this.checkBoxTitle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxTitle.Location = new System.Drawing.Point(144, 40);
			this.checkBoxTitle.Name = "checkBoxTitle";
			this.checkBoxTitle.Size = new System.Drawing.Size(104, 16);
			this.checkBoxTitle.TabIndex = 7;
			this.checkBoxTitle.Text = "Use Title Text";
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 166);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkBoxTitle,
																		  this.label2,
																		  this.label1,
																		  this.numericUpDownWidth,
																		  this.numericUpDownHeight,
																		  this.textBoxText,
																		  this.textBoxTitle,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "NotifyWindow Tester";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
        //[STAThread]
        //static void Main() 
        //{
        //    Application.Run(new Form1());
        //}

		private void button1_Click(object sender, System.EventArgs e)
		{
			NotifyWindow nw;
			if (checkBoxTitle.Checked)
			{
				nw = new NotifyWindow (textBoxTitle.Text, textBoxText.Text);
				nw.TitleClicked += new System.EventHandler (titleClick);
			}
			else
				nw = new NotifyWindow (textBoxText.Text);
			nw.TextClicked += new System.EventHandler (textClick);
			nw.SetDimensions ((int) numericUpDownWidth.Value, (int) numericUpDownHeight.Value);
			nw.Notify();
		}

		protected void titleClick (object sender, System.EventArgs e)
		{
			MessageBox.Show ("Title text clicked");
		}

		protected void textClick (object sender, System.EventArgs e)
		{
			MessageBox.Show ("Text clicked");
		}
	}
}
