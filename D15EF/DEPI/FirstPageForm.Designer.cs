namespace DEPI
{
    partial class FirstPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPageForm));
            CrsButton = new Button();
            DeptButton = new Button();
            InstButton = new Button();
            StButton = new Button();
            TopButton = new Button();
            InstCrsButton = new Button();
            StCrsButton = new Button();
            SuspendLayout();
            // 
            // CrsButton
            // 
            CrsButton.BackColor = Color.Snow;
            CrsButton.Font = new Font("Script MT Bold", 18F);
            CrsButton.ForeColor = Color.DarkRed;
            CrsButton.Location = new Point(332, 172);
            CrsButton.Name = "CrsButton";
            CrsButton.Size = new Size(147, 51);
            CrsButton.TabIndex = 2;
            CrsButton.Text = "Courses";
            CrsButton.UseVisualStyleBackColor = false;
            CrsButton.Click += CrsButton_Click;
            // 
            // DeptButton
            // 
            DeptButton.BackColor = Color.Snow;
            DeptButton.Font = new Font("Script MT Bold", 18F);
            DeptButton.ForeColor = Color.DarkRed;
            DeptButton.Location = new Point(332, 52);
            DeptButton.Name = "DeptButton";
            DeptButton.Size = new Size(147, 51);
            DeptButton.TabIndex = 1;
            DeptButton.Text = "Departments";
            DeptButton.UseVisualStyleBackColor = false;
            DeptButton.Click += DeptButton_Click;
            // 
            // InstButton
            // 
            InstButton.BackColor = Color.Snow;
            InstButton.Font = new Font("Script MT Bold", 18F);
            InstButton.ForeColor = Color.DarkRed;
            InstButton.Location = new Point(606, 104);
            InstButton.Name = "InstButton";
            InstButton.Size = new Size(147, 51);
            InstButton.TabIndex = 3;
            InstButton.Text = "Instructors";
            InstButton.UseVisualStyleBackColor = false;
            InstButton.Click += InstButton_Click;
            // 
            // StButton
            // 
            StButton.BackColor = Color.Snow;
            StButton.Font = new Font("Script MT Bold", 18F);
            StButton.ForeColor = Color.DarkRed;
            StButton.Location = new Point(42, 104);
            StButton.Name = "StButton";
            StButton.Size = new Size(147, 51);
            StButton.TabIndex = 0;
            StButton.Text = "Students";
            StButton.UseVisualStyleBackColor = false;
            StButton.Click += StButton_Click;
            // 
            // TopButton
            // 
            TopButton.BackColor = Color.Snow;
            TopButton.Font = new Font("Script MT Bold", 18F);
            TopButton.ForeColor = Color.DarkRed;
            TopButton.Location = new Point(332, 305);
            TopButton.Name = "TopButton";
            TopButton.Size = new Size(147, 51);
            TopButton.TabIndex = 5;
            TopButton.Text = "Topics";
            TopButton.UseVisualStyleBackColor = false;
            TopButton.Click += TopButton_Click;
            // 
            // InstCrsButton
            // 
            InstCrsButton.BackColor = Color.Snow;
            InstCrsButton.Font = new Font("Script MT Bold", 18F);
            InstCrsButton.ForeColor = Color.DarkRed;
            InstCrsButton.Location = new Point(606, 196);
            InstCrsButton.Name = "InstCrsButton";
            InstCrsButton.Size = new Size(147, 73);
            InstCrsButton.TabIndex = 6;
            InstCrsButton.Text = "Instructor Courses";
            InstCrsButton.UseVisualStyleBackColor = false;
            InstCrsButton.Click += InstCrsButton_Click;
            // 
            // StCrsButton
            // 
            StCrsButton.BackColor = Color.Snow;
            StCrsButton.Font = new Font("Script MT Bold", 18F);
            StCrsButton.ForeColor = Color.DarkRed;
            StCrsButton.Location = new Point(42, 196);
            StCrsButton.Name = "StCrsButton";
            StCrsButton.Size = new Size(147, 73);
            StCrsButton.TabIndex = 7;
            StCrsButton.Text = "Student Courses";
            StCrsButton.UseVisualStyleBackColor = false;
            StCrsButton.Click += StCrsButton_Click;
            // 
            // FirstPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(StCrsButton);
            Controls.Add(InstCrsButton);
            Controls.Add(TopButton);
            Controls.Add(InstButton);
            Controls.Add(StButton);
            Controls.Add(CrsButton);
            Controls.Add(DeptButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FirstPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First Page";
            ResumeLayout(false);
        }

        #endregion

        private Button CrsButton;
        private Button DeptButton;
        private Button InstButton;
        private Button StButton;
        private Button TopButton;
        private Button InstCrsButton;
        private Button StCrsButton;
    }
}
