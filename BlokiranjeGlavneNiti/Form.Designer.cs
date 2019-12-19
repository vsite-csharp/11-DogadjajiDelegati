namespace Vsite.CSharp.DogađajiDelegati
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.Location = new System.Drawing.Point(16, 15);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(349, 22);
            this.textBoxTime.TabIndex = 0;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // buttonBlock
            // 
            this.buttonBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlock.Location = new System.Drawing.Point(267, 297);
            this.buttonBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(100, 28);
            this.buttonBlock.TabIndex = 1;
            this.buttonBlock.Text = "&Block";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 340);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.textBoxTime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form";
            this.Text = "Blokiranje glavne niti";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Timer timer1;
    }
}

