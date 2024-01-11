namespace Vsite.CSharp.DogađajiDelegati
{
    partial class EventsForm
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
            label1 = new Label();
            textBox = new TextBox();
            buttonDelete = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "&Write some text:";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(135, 9);
            textBox.Margin = new Padding(4, 5, 4, 5);
            textBox.Name = "textBox";
            textBox.Size = new Size(268, 27);
            textBox.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(304, 49);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 35);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "&Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(304, 214);
            buttonClose.Margin = new Padding(4, 5, 4, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 35);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "E&xit";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 268);
            Controls.Add(buttonClose);
            Controls.Add(buttonDelete);
            Controls.Add(textBox);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(434, 298);
            Name = "EventsForm";
            Text = "Events";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonClose;
    }
}

