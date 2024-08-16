namespace DEPI
{
    partial class InstsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstsForm));
            BackButton = new Button();
            StdGView = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            DeptTBox = new TextBox();
            SalTBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DegreeTBox = new TextBox();
            NameTBox = new TextBox();
            IdTBox = new TextBox();
            ShowICrsButton = new Button();
            ShowDeptsButton = new Button();
            ShowManagedButton = new Button();
            RestButton = new Button();
            DistButton = new Button();
            LstButton = new Button();
            FstButton = new Button();
            ((System.ComponentModel.ISupportInitialize)StdGView).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FloralWhite;
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackButton.ForeColor = Color.Indigo;
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(63, 33);
            BackButton.TabIndex = 2;
            BackButton.Text = "<<Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StdGView
            // 
            StdGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StdGView.BackgroundColor = SystemColors.ControlLight;
            StdGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StdGView.Location = new Point(30, 288);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(360, 66);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 50;
            label5.Text = "Department ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(391, 24);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 51;
            label6.Text = "Salary";
            // 
            // DeptTBox
            // 
            DeptTBox.Location = new Point(488, 66);
            DeptTBox.Name = "DeptTBox";
            DeptTBox.Size = new Size(125, 23);
            DeptTBox.TabIndex = 47;
            DeptTBox.TextChanged += DeptTBox_TextChanged;
            // 
            // SalTBox
            // 
            SalTBox.Location = new Point(488, 24);
            SalTBox.Name = "SalTBox";
            SalTBox.Size = new Size(125, 23);
            SalTBox.TabIndex = 48;
            SalTBox.TextChanged += SalTBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(88, 106);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 44;
            label3.Text = "Degree";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(94, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 45;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(106, 24);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 43;
            label1.Text = "ID";
            // 
            // DegreeTBox
            // 
            DegreeTBox.Location = new Point(168, 105);
            DegreeTBox.Name = "DegreeTBox";
            DegreeTBox.Size = new Size(125, 23);
            DegreeTBox.TabIndex = 42;
            DegreeTBox.TextChanged += DegreeTBox_TextChanged;
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(168, 63);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 41;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(168, 21);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 40;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowICrsButton
            // 
            ShowICrsButton.Font = new Font("Segoe UI", 10F);
            ShowICrsButton.Location = new Point(472, 189);
            ShowICrsButton.Name = "ShowICrsButton";
            ShowICrsButton.Size = new Size(198, 30);
            ShowICrsButton.TabIndex = 38;
            ShowICrsButton.Text = "Show Instructor Courses";
            ShowICrsButton.UseVisualStyleBackColor = true;
            ShowICrsButton.Click += ShowICrsButton_Click;
            // 
            // ShowDeptsButton
            // 
            ShowDeptsButton.Font = new Font("Segoe UI", 10F);
            ShowDeptsButton.Location = new Point(245, 189);
            ShowDeptsButton.Name = "ShowDeptsButton";
            ShowDeptsButton.Size = new Size(198, 30);
            ShowDeptsButton.TabIndex = 37;
            ShowDeptsButton.Text = "Show Instructor Departments";
            ShowDeptsButton.UseVisualStyleBackColor = true;
            ShowDeptsButton.Click += ShowDeptsButton_Click;
            // 
            // ShowManagedButton
            // 
            ShowManagedButton.Font = new Font("Segoe UI", 10F);
            ShowManagedButton.Location = new Point(30, 189);
            ShowManagedButton.Name = "ShowManagedButton";
            ShowManagedButton.Size = new Size(185, 30);
            ShowManagedButton.TabIndex = 36;
            ShowManagedButton.Text = "Show Managed Depts";
            ShowManagedButton.UseVisualStyleBackColor = true;
            ShowManagedButton.Click += ShowManagedButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(675, 235);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
            RestButton.TabIndex = 35;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(257, 235);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 34;
            DistButton.Text = "Distinct Inst";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(144, 235);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 39;
            LstButton.Text = "Last Inst";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(30, 235);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 33;
            FstButton.Text = "First Inst";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // InstsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 532);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(DeptTBox);
            Controls.Add(SalTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DegreeTBox);
            Controls.Add(NameTBox);
            Controls.Add(IdTBox);
            Controls.Add(ShowICrsButton);
            Controls.Add(ShowDeptsButton);
            Controls.Add(ShowManagedButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InstsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructors";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private DataGridView StdGView;
        private Label label5;
        private Label label6;
        private TextBox DeptTBox;
        private TextBox SalTBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DegreeTBox;
        private TextBox NameTBox;
        private TextBox IdTBox;
        private Button ShowICrsButton;
        private Button ShowDeptsButton;
        private Button ShowManagedButton;
        private Button RestButton;
        private Button DistButton;
        private Button LstButton;
        private Button FstButton;
    }
}