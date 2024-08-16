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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StsForm));
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label13 = new Label();
            txtSuperId = new TextBox();
            label12 = new Label();
            txtDeptId = new TextBox();
            label11 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtAge = new TextBox();
            label9 = new Label();
            txtLName = new TextBox();
            txtFName = new TextBox();
            label8 = new Label();
            InsertUpdateButton = new Button();
            DeleteButton = new Button();
            txtStIdDel = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)StdGView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FloralWhite;
            BackButton.Dock = DockStyle.Left;
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackButton.ForeColor = Color.Indigo;
            BackButton.Location = new Point(0, 0);
            BackButton.MaximumSize = new Size(0, 30);
            BackButton.MinimumSize = new Size(75, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 30);
            BackButton.TabIndex = 0;
            BackButton.Text = "<<Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StdGView
            // 
            StdGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StdGView.BackgroundColor = SystemColors.ControlLight;
            StdGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StdGView.Location = new Point(35, 280);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(761, 240);
            StdGView.TabIndex = 1;
            StdGView.RowStateChanged += StdGView_RowStateChanged;
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
            RestButton.Size = new Size(99, 33);
            RestButton.TabIndex = 3;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(173, 58);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 4;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // FNameTBox
            // 
            FNameTBox.Location = new Point(173, 100);
            FNameTBox.Name = "FNameTBox";
            FNameTBox.Size = new Size(125, 23);
            FNameTBox.TabIndex = 4;
            FNameTBox.TextChanged += FNameTBox_TextChanged;
            // 
            // LNameTBox
            // 
            LNameTBox.Location = new Point(173, 142);
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
            label1.Location = new Point(111, 61);
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
            label2.Location = new Point(84, 100);
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
            label3.Location = new Point(84, 142);
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
            label4.Location = new Point(334, 146);
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
            label5.Location = new Point(354, 103);
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
            label6.Location = new Point(368, 61);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 11;
            label6.Text = "Age";
            // 
            // DeptTBox
            // 
            DeptTBox.Location = new Point(449, 146);
            DeptTBox.Name = "DeptTBox";
            DeptTBox.Size = new Size(125, 23);
            DeptTBox.TabIndex = 6;
            DeptTBox.TextChanged += DeptTBox_TextChanged;
            // 
            // AddrTBox
            // 
            AddrTBox.Location = new Point(449, 104);
            AddrTBox.Name = "AddrTBox";
            AddrTBox.Size = new Size(125, 23);
            AddrTBox.TabIndex = 7;
            AddrTBox.TextChanged += AddrTBox_TextChanged;
            // 
            // AgeTBox
            // 
            AgeTBox.Location = new Point(449, 62);
            AgeTBox.Name = "AgeTBox";
            AgeTBox.Size = new Size(125, 23);
            AgeTBox.TabIndex = 8;
            AgeTBox.TextChanged += AgeTBox_TextChanged;
            // 
            // SuperTBox
            // 
            SuperTBox.Location = new Point(627, 117);
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
            label7.Location = new Point(639, 91);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.570282F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.429718F));
            tableLayoutPanel1.Controls.Add(label13, 0, 5);
            tableLayoutPanel1.Controls.Add(txtSuperId, 1, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDeptId, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 3);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(txtAge, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtLName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtFName, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(868, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(249, 287);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(3, 235);
            label13.Name = "label13";
            label13.Size = new Size(84, 40);
            label13.TabIndex = 36;
            label13.Text = "Supervisor ID";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSuperId
            // 
            txtSuperId.Location = new Point(109, 238);
            txtSuperId.Name = "txtSuperId";
            txtSuperId.PlaceholderText = "NULL";
            txtSuperId.Size = new Size(114, 23);
            txtSuperId.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(3, 188);
            label12.Name = "label12";
            label12.Size = new Size(94, 40);
            label12.TabIndex = 34;
            label12.Text = "Department ID";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDeptId
            // 
            txtDeptId.Location = new Point(109, 191);
            txtDeptId.Name = "txtDeptId";
            txtDeptId.PlaceholderText = "NULL";
            txtDeptId.Size = new Size(114, 23);
            txtDeptId.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(3, 141);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 32;
            label11.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(109, 144);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "NULL";
            txtAddress.Size = new Size(114, 23);
            txtAddress.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(3, 94);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 30;
            label10.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(109, 97);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "NULL";
            txtAge.Size = new Size(114, 23);
            txtAge.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(3, 47);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 28;
            label9.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(109, 50);
            txtLName.Name = "txtLName";
            txtLName.PlaceholderText = "NULL";
            txtLName.Size = new Size(114, 23);
            txtLName.TabIndex = 27;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(109, 3);
            txtFName.Name = "txtFName";
            txtFName.PlaceholderText = "NULL";
            txtFName.Size = new Size(114, 23);
            txtFName.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 25;
            label8.Text = "First Name";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(907, 354);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 25;
            InsertUpdateButton.Text = "Insert / Update";
            InsertUpdateButton.UseVisualStyleBackColor = true;
            InsertUpdateButton.Click += InsertUpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(942, 445);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 26;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtStIdDel
            // 
            txtStIdDel.Location = new Point(980, 416);
            txtStIdDel.Name = "txtStIdDel";
            txtStIdDel.Size = new Size(125, 23);
            txtStIdDel.TabIndex = 36;
            txtStIdDel.TextChanged += txtStIdDel_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(866, 414);
            label14.Name = "label14";
            label14.Size = new Size(103, 25);
            label14.TabIndex = 38;
            label14.Text = "Student ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(841, 9);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 39;
            label15.Text = "Make Changes On Database";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(303, 9);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 40;
            label16.Text = "Search And Display";
            // 
            // StsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1157, 523);
            ControlBox = false;
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtStIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label13;
        private TextBox txtSuperId;
        private Label label12;
        private TextBox txtDeptId;
        private Label label11;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtAge;
        private Label label9;
        private TextBox txtLName;
        private TextBox txtFName;
        private Label label8;
        private Button InsertUpdateButton;
        private Button DeleteButton;
        private TextBox txtStIdDel;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}