namespace DEPI
{
    partial class StsForm
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
            BackButton = new Button();
            StdGView = new DataGridView();
            FstButton = new Button();
            LstButton = new Button();
            DistButton = new Button();
            RestButton = new Button();
            IdTBox = new TextBox();
            FNameTBox = new TextBox();
            LNameTBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DeptTBox = new TextBox();
            AddrTBox = new TextBox();
            AgeTBox = new TextBox();
            SuperTBox = new TextBox();
            label7 = new Label();
            ShowStSuperButton = new Button();
            ShowDeptButton = new Button();
            ShowStCrsButton = new Button();
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
            BackButton.TabIndex = 0;
            BackButton.Text = "<<Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StdGView
            // 
            StdGView.BackgroundColor = SystemColors.ControlLight;
            StdGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StdGView.Location = new Point(35, 280);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(746, 240);
            StdGView.TabIndex = 1;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(35, 232);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 2;
            FstButton.Text = "First Student";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(149, 232);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 3;
            LstButton.Text = "Last Student";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(262, 232);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 3;
            DistButton.Text = "Distinct Stud";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(694, 232);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
            RestButton.TabIndex = 3;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(173, 18);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 4;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // FNameTBox
            // 
            FNameTBox.Location = new Point(173, 60);
            FNameTBox.Name = "FNameTBox";
            FNameTBox.Size = new Size(125, 23);
            FNameTBox.TabIndex = 4;
            FNameTBox.TextChanged += FNameTBox_TextChanged;
            // 
            // LNameTBox
            // 
            LNameTBox.Location = new Point(173, 102);
            LNameTBox.Name = "LNameTBox";
            LNameTBox.Size = new Size(125, 23);
            LNameTBox.TabIndex = 4;
            LNameTBox.TextChanged += LNameTBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(111, 21);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(84, 60);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(84, 102);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(334, 106);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 9;
            label4.Text = "Department ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(354, 63);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(368, 21);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 11;
            label6.Text = "Age";
            // 
            // DeptTBox
            // 
            DeptTBox.Location = new Point(449, 106);
            DeptTBox.Name = "DeptTBox";
            DeptTBox.Size = new Size(125, 23);
            DeptTBox.TabIndex = 6;
            DeptTBox.TextChanged += DeptTBox_TextChanged;
            // 
            // AddrTBox
            // 
            AddrTBox.Location = new Point(449, 64);
            AddrTBox.Name = "AddrTBox";
            AddrTBox.Size = new Size(125, 23);
            AddrTBox.TabIndex = 7;
            AddrTBox.TextChanged += AddrTBox_TextChanged;
            // 
            // AgeTBox
            // 
            AgeTBox.Location = new Point(449, 22);
            AgeTBox.Name = "AgeTBox";
            AgeTBox.Size = new Size(125, 23);
            AgeTBox.TabIndex = 8;
            AgeTBox.TextChanged += AgeTBox_TextChanged;
            // 
            // SuperTBox
            // 
            SuperTBox.Location = new Point(627, 77);
            SuperTBox.Name = "SuperTBox";
            SuperTBox.Size = new Size(125, 23);
            SuperTBox.TabIndex = 6;
            SuperTBox.TextChanged += SuperTBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(639, 51);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 9;
            label7.Text = "Supervisor ID";
            // 
            // ShowStSuperButton
            // 
            ShowStSuperButton.Font = new Font("Segoe UI", 10F);
            ShowStSuperButton.Location = new Point(35, 186);
            ShowStSuperButton.Name = "ShowStSuperButton";
            ShowStSuperButton.Size = new Size(185, 30);
            ShowStSuperButton.TabIndex = 3;
            ShowStSuperButton.Text = "Show Students Supervisors";
            ShowStSuperButton.UseVisualStyleBackColor = true;
            ShowStSuperButton.Click += ShowStSuperButton_Click;
            // 
            // ShowDeptButton
            // 
            ShowDeptButton.Font = new Font("Segoe UI", 10F);
            ShowDeptButton.Location = new Point(250, 186);
            ShowDeptButton.Name = "ShowDeptButton";
            ShowDeptButton.Size = new Size(198, 30);
            ShowDeptButton.TabIndex = 3;
            ShowDeptButton.Text = "Show Students Departments";
            ShowDeptButton.UseVisualStyleBackColor = true;
            ShowDeptButton.Click += ShowDeptButton_Click;
            // 
            // ShowStCrsButton
            // 
            ShowStCrsButton.Font = new Font("Segoe UI", 10F);
            ShowStCrsButton.Location = new Point(477, 186);
            ShowStCrsButton.Name = "ShowStCrsButton";
            ShowStCrsButton.Size = new Size(198, 30);
            ShowStCrsButton.TabIndex = 3;
            ShowStCrsButton.Text = "Show Students Courses";
            ShowStCrsButton.UseVisualStyleBackColor = true;
            ShowStCrsButton.Click += ShowStCrsButton_Click;
            // 
            // StsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(820, 523);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(SuperTBox);
            Controls.Add(DeptTBox);
            Controls.Add(AddrTBox);
            Controls.Add(AgeTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LNameTBox);
            Controls.Add(FNameTBox);
            Controls.Add(IdTBox);
            Controls.Add(ShowStCrsButton);
            Controls.Add(ShowDeptButton);
            Controls.Add(ShowStSuperButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Name = "StsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private DataGridView StdGView;
        private Button FstButton;
        private Button LstButton;
        private Button DistButton;
        private Button RestButton;
        private TextBox IdTBox;
        private TextBox FNameTBox;
        private TextBox LNameTBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox DeptTBox;
        private TextBox AddrTBox;
        private TextBox AgeTBox;
        private TextBox SuperTBox;
        private Label label7;
        private Button ShowStSuperButton;
        private Button ShowDeptButton;
        private Button ShowStCrsButton;
    }
}