namespace ESolutions.ImageResizer
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.selectSourceButton = new System.Windows.Forms.Button();
			this.selectTargetButton = new System.Windows.Forms.Button();
			this.targetTextBox = new System.Windows.Forms.TextBox();
			this.longestSideImageTextBox = new System.Windows.Forms.TextBox();
			this.goButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.longestSizeThumbTextBox = new System.Windows.Forms.TextBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.finishedLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(24, 31);
			label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(80, 25);
			label1.TabIndex = 2;
			label1.Text = "Source";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(24, 81);
			label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(74, 25);
			label2.TabIndex = 5;
			label2.Text = "Target";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(24, 131);
			label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(199, 25);
			label3.TabIndex = 7;
			label3.Text = "Longest side image";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(24, 181);
			label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(200, 25);
			label4.TabIndex = 10;
			label4.Text = "Longest side thumb";
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextBox.Enabled = false;
			this.sourceTextBox.Location = new System.Drawing.Point(234, 23);
			this.sourceTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.Size = new System.Drawing.Size(788, 31);
			this.sourceTextBox.TabIndex = 0;
			// 
			// selectSourceButton
			// 
			this.selectSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectSourceButton.Location = new System.Drawing.Point(1088, 21);
			this.selectSourceButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.selectSourceButton.Name = "selectSourceButton";
			this.selectSourceButton.Size = new System.Drawing.Size(60, 44);
			this.selectSourceButton.TabIndex = 1;
			this.selectSourceButton.Text = "...";
			this.selectSourceButton.UseVisualStyleBackColor = true;
			this.selectSourceButton.Click += new System.EventHandler(this.SelectSourceButton_Click);
			// 
			// selectTargetButton
			// 
			this.selectTargetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectTargetButton.Location = new System.Drawing.Point(1088, 71);
			this.selectTargetButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.selectTargetButton.Name = "selectTargetButton";
			this.selectTargetButton.Size = new System.Drawing.Size(60, 44);
			this.selectTargetButton.TabIndex = 4;
			this.selectTargetButton.Text = "...";
			this.selectTargetButton.UseVisualStyleBackColor = true;
			this.selectTargetButton.Click += new System.EventHandler(this.SelectTargetButton_Click);
			// 
			// targetTextBox
			// 
			this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.targetTextBox.Enabled = false;
			this.targetTextBox.Location = new System.Drawing.Point(234, 73);
			this.targetTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.targetTextBox.Name = "targetTextBox";
			this.targetTextBox.Size = new System.Drawing.Size(788, 31);
			this.targetTextBox.TabIndex = 3;
			// 
			// longestSideImageTextBox
			// 
			this.longestSideImageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.longestSideImageTextBox.Location = new System.Drawing.Point(234, 123);
			this.longestSideImageTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.longestSideImageTextBox.Name = "longestSideImageTextBox";
			this.longestSideImageTextBox.Size = new System.Drawing.Size(788, 31);
			this.longestSideImageTextBox.TabIndex = 6;
			this.longestSideImageTextBox.Text = "600";
			this.longestSideImageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnlyTextBox_KeyPress);
			// 
			// goButton
			// 
			this.goButton.Location = new System.Drawing.Point(234, 223);
			this.goButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.goButton.Name = "goButton";
			this.goButton.Size = new System.Drawing.Size(86, 44);
			this.goButton.TabIndex = 8;
			this.goButton.Text = "Go";
			this.goButton.UseVisualStyleBackColor = true;
			this.goButton.Click += new System.EventHandler(this.GoButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// longestSizeThumbTextBox
			// 
			this.longestSizeThumbTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.longestSizeThumbTextBox.Location = new System.Drawing.Point(234, 173);
			this.longestSizeThumbTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.longestSizeThumbTextBox.Name = "longestSizeThumbTextBox";
			this.longestSizeThumbTextBox.Size = new System.Drawing.Size(788, 31);
			this.longestSizeThumbTextBox.TabIndex = 9;
			this.longestSizeThumbTextBox.Text = "60";
			this.longestSizeThumbTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnlyTextBox_KeyPress);
			// 
			// progressBar1
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(234, 279);
			this.progressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.progressBar.Name = "progressBar1";
			this.progressBar.Size = new System.Drawing.Size(792, 44);
			this.progressBar.TabIndex = 11;
			// 
			// finishedLabel
			// 
			this.finishedLabel.AutoSize = true;
			this.finishedLabel.ForeColor = System.Drawing.Color.Green;
			this.finishedLabel.Location = new System.Drawing.Point(228, 329);
			this.finishedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.finishedLabel.Name = "finishedLabel";
			this.finishedLabel.Size = new System.Drawing.Size(100, 25);
			this.finishedLabel.TabIndex = 12;
			this.finishedLabel.Text = "Finished!";
			this.finishedLabel.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 385);
			this.Controls.Add(this.finishedLabel);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(label4);
			this.Controls.Add(this.longestSizeThumbTextBox);
			this.Controls.Add(this.goButton);
			this.Controls.Add(label3);
			this.Controls.Add(this.longestSideImageTextBox);
			this.Controls.Add(label2);
			this.Controls.Add(this.selectTargetButton);
			this.Controls.Add(this.targetTextBox);
			this.Controls.Add(label1);
			this.Controls.Add(this.selectSourceButton);
			this.Controls.Add(this.sourceTextBox);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "MainForm";
			this.Text = "Image resizer";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.Button selectSourceButton;
		private System.Windows.Forms.Button selectTargetButton;
		private System.Windows.Forms.TextBox targetTextBox;
		private System.Windows.Forms.TextBox longestSideImageTextBox;
		private System.Windows.Forms.Button goButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox longestSizeThumbTextBox;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label finishedLabel;
	}
}

