namespace Relative_Path
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonPath2 = new System.Windows.Forms.Button();
			this.buttonPath1 = new System.Windows.Forms.Button();
			this.textBoxRelativePath = new System.Windows.Forms.TextBox();
			this.textBoxPath2 = new System.Windows.Forms.TextBox();
			this.textBoxPath1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonPath2
			// 
			this.buttonPath2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPath2.Location = new System.Drawing.Point(346, 36);
			this.buttonPath2.Name = "buttonPath2";
			this.buttonPath2.Size = new System.Drawing.Size(75, 23);
			this.buttonPath2.TabIndex = 10;
			this.buttonPath2.Text = "Path 2";
			this.buttonPath2.UseVisualStyleBackColor = true;
			// 
			// buttonPath1
			// 
			this.buttonPath1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPath1.Location = new System.Drawing.Point(346, 10);
			this.buttonPath1.Name = "buttonPath1";
			this.buttonPath1.Size = new System.Drawing.Size(75, 23);
			this.buttonPath1.TabIndex = 11;
			this.buttonPath1.Text = "Path 1";
			this.buttonPath1.UseVisualStyleBackColor = true;
			// 
			// textBoxRelativePath
			// 
			this.textBoxRelativePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRelativePath.Location = new System.Drawing.Point(12, 65);
			this.textBoxRelativePath.Name = "textBoxRelativePath";
			this.textBoxRelativePath.ReadOnly = true;
			this.textBoxRelativePath.Size = new System.Drawing.Size(409, 20);
			this.textBoxRelativePath.TabIndex = 7;
			// 
			// textBoxPath2
			// 
			this.textBoxPath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPath2.Location = new System.Drawing.Point(12, 38);
			this.textBoxPath2.Name = "textBoxPath2";
			this.textBoxPath2.Size = new System.Drawing.Size(328, 20);
			this.textBoxPath2.TabIndex = 8;
			// 
			// textBoxPath1
			// 
			this.textBoxPath1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPath1.Location = new System.Drawing.Point(12, 12);
			this.textBoxPath1.Name = "textBoxPath1";
			this.textBoxPath1.Size = new System.Drawing.Size(328, 20);
			this.textBoxPath1.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 98);
			this.Controls.Add(this.buttonPath2);
			this.Controls.Add(this.buttonPath1);
			this.Controls.Add(this.textBoxRelativePath);
			this.Controls.Add(this.textBoxPath2);
			this.Controls.Add(this.textBoxPath1);
			this.Name = "Form1";
			this.Text = "A";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonPath2;
		private System.Windows.Forms.Button buttonPath1;
		private System.Windows.Forms.TextBox textBoxRelativePath;
		private System.Windows.Forms.TextBox textBoxPath2;
		private System.Windows.Forms.TextBox textBoxPath1;
	}
}

