namespace Vsite.CSharp.DogađajiDelegati
{
    partial class KodDvaBotuna
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
            this.button = new System.Windows.Forms.Button();
            this.buttonMy = new MyButton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(16, 15);
            this.button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 28);
            this.button.TabIndex = 0;
            this.button.Text = "&Button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonMy
            // 
            this.buttonMy.Location = new System.Drawing.Point(16, 69);
            this.buttonMy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMy.Name = "buttonMy";
            this.buttonMy.Size = new System.Drawing.Size(100, 28);
            this.buttonMy.TabIndex = 1;
            this.buttonMy.Text = "&My button";
            this.buttonMy.UseVisualStyleBackColor = true;
            this.buttonMy.Click += new System.EventHandler(this.ButtonMy_Click);
            // 
            // KodDvaBotuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 457);
            this.Controls.Add(this.buttonMy);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KodDvaBotuna";
            this.Text = "Kod dva botuna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private MyButton buttonMy;
    }
}