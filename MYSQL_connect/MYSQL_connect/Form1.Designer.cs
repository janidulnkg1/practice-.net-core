namespace MYSQL_connect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnView = new Button();
            lbData = new ListBox();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.Location = new Point(136, 77);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(82, 22);
            btnView.TabIndex = 0;
            btnView.Text = "View Data";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // lbData
            // 
            lbData.FormattingEnabled = true;
            lbData.ItemHeight = 15;
            lbData.Location = new Point(113, 135);
            lbData.Name = "lbData";
            lbData.Size = new Size(238, 154);
            lbData.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lbData);
            Controls.Add(btnView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnView;
        private ListBox lbData;
    }
}