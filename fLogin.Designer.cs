namespace cshop
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            bLogin = new Button();
            bClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(200, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 108);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 154);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(200, 105);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(189, 23);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(200, 151);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(189, 23);
            tbPassword.TabIndex = 4;
            // 
            // bLogin
            // 
            bLogin.Location = new Point(228, 192);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(75, 23);
            bLogin.TabIndex = 5;
            bLogin.Text = "Login";
            bLogin.UseVisualStyleBackColor = true;
            bLogin.Click += bLogin_Click;
            // 
            // bClear
            // 
            bClear.Location = new Point(228, 230);
            bClear.Name = "bClear";
            bClear.Size = new Size(75, 23);
            bClear.TabIndex = 6;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(522, 264);
            Controls.Add(bClear);
            Controls.Add(bLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button bLogin;
        private Button bClear;
    }
}
