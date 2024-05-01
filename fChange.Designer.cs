namespace cshop
{
    partial class fChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChange));
            bChange = new Button();
            tbDate = new TextBox();
            tbCust = new TextBox();
            tbItem = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bChange
            // 
            bChange.Location = new Point(64, 142);
            bChange.Name = "bChange";
            bChange.Size = new Size(97, 31);
            bChange.TabIndex = 13;
            bChange.Text = "Change Order";
            bChange.UseVisualStyleBackColor = true;
            bChange.Click += bChange_Click;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(99, 100);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(100, 23);
            tbDate.TabIndex = 12;
            // 
            // tbCust
            // 
            tbCust.Location = new Point(99, 64);
            tbCust.Name = "tbCust";
            tbCust.Size = new Size(100, 23);
            tbCust.TabIndex = 11;
            // 
            // tbItem
            // 
            tbItem.Location = new Point(99, 29);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(100, 23);
            tbItem.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 103);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 8;
            label2.Text = "Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Item Name";
            // 
            // fChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 189);
            Controls.Add(bChange);
            Controls.Add(tbDate);
            Controls.Add(tbCust);
            Controls.Add(tbItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bChange;
        private TextBox tbDate;
        private TextBox tbCust;
        private TextBox tbItem;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}