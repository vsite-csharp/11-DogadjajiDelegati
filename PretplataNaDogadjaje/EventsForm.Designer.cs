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
            label1.Location = new Point(20, 17);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "&Write some text:";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(168, 12);
            textBox.Margin = new Padding(5, 6, 5, 6);
            textBox.Name = "textBox";
            textBox.Size = new Size(334, 31);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(380, 62);
            buttonDelete.Margin = new Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 44);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "&Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(380, 267);
            buttonClose.Margin = new Padding(5, 6, 5, 6);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 44);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "E&xit";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 335);
            Controls.Add(buttonClose);
            Controls.Add(buttonDelete);
            Controls.Add(textBox);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(535, 352);
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

