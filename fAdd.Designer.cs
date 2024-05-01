namespace cshop
{
    partial class fAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdd));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbItem = new TextBox();
            tbCust = new TextBox();
            tbDate = new TextBox();
            bAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 104);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // tbItem
            // 
            tbItem.Location = new Point(100, 30);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(100, 23);
            tbItem.TabIndex = 3;
            // 
            // tbCust
            // 
            tbCust.Location = new Point(100, 65);
            tbCust.Name = "tbCust";
            tbCust.Size = new Size(100, 23);
            tbCust.TabIndex = 4;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(100, 101);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(100, 23);
            tbDate.TabIndex = 5;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(62, 142);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(97, 31);
            bAdd.TabIndex = 6;
            bAdd.Text = "Add Order";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // fAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 189);
            Controls.Add(bAdd);
            Controls.Add(tbDate);
            Controls.Add(tbCust);
            Controls.Add(tbItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbItem;
        private TextBox tbCust;
        private TextBox tbDate;
        private Button bAdd;
    }
}