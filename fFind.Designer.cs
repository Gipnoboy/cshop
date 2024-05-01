namespace cshop
{
    partial class fFind
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
            tbDate = new TextBox();
            tbCust = new TextBox();
            tbItem = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbDate
            // 
            tbDate.Location = new Point(108, 96);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(100, 23);
            tbDate.TabIndex = 11;
            // 
            // tbCust
            // 
            tbCust.Location = new Point(108, 60);
            tbCust.Name = "tbCust";
            tbCust.Size = new Size(100, 23);
            tbCust.TabIndex = 10;
            // 
            // tbItem
            // 
            tbItem.Location = new Point(108, 25);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(100, 23);
            tbItem.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 99);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 63);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Item Name";
            // 
            // button1
            // 
            button1.Location = new Point(79, 142);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 12;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fFind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 188);
            Controls.Add(button1);
            Controls.Add(tbDate);
            Controls.Add(tbCust);
            Controls.Add(tbItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fFind";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find a document";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDate;
        private TextBox tbCust;
        private TextBox tbItem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}