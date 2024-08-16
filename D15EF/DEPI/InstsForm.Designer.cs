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
            label15 = new Label();
            DeleteButton = new Button();
            txtInstIdDel = new TextBox();
            label14 = new Label();
            InsertUpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            txtDeptID = new TextBox();
            label10 = new Label();
            txtSalary = new TextBox();
            label9 = new Label();
            txtDegree = new TextBox();
            txtInstName = new TextBox();
            label8 = new Label();
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
            StdGView.RowStateChanged += StdGView_RowStateChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(335, 117);
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
            label6.Location = new Point(366, 75);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 51;
            label6.Text = "Salary";
            // 
            // DeptTBox
            // 
            DeptTBox.Location = new Point(463, 117);
            DeptTBox.Name = "DeptTBox";
            DeptTBox.Size = new Size(125, 23);
            DeptTBox.TabIndex = 47;
            DeptTBox.TextChanged += DeptTBox_TextChanged;
            // 
            // SalTBox
            // 
            SalTBox.Location = new Point(463, 75);
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
            label3.Location = new Point(84, 148);
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
            label2.Location = new Point(90, 105);
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
            label1.Location = new Point(102, 66);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 43;
            label1.Text = "ID";
            // 
            // DegreeTBox
            // 
            DegreeTBox.Location = new Point(164, 147);
            DegreeTBox.Name = "DegreeTBox";
            DegreeTBox.Size = new Size(125, 23);
            DegreeTBox.TabIndex = 42;
            DegreeTBox.TextChanged += DegreeTBox_TextChanged;
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(164, 105);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 41;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(164, 63);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 40;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowICrsButton
            // 
            ShowICrsButton.Font = new Font("Segoe UI", 10F);
            ShowICrsButton.Location = new Point(471, 203);
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
            ShowDeptsButton.Location = new Point(244, 203);
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
            ShowManagedButton.Location = new Point(29, 203);
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
            RestButton.Location = new Point(674, 249);
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
            DistButton.Location = new Point(256, 249);
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
            LstButton.Location = new Point(143, 249);
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
            FstButton.Location = new Point(29, 249);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 33;
            FstButton.Text = "First Inst";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(792, 19);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 57;
            label15.Text = "Make Changes On Database";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(891, 391);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 54;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtInstIdDel
            // 
            txtInstIdDel.Location = new Point(941, 358);
            txtInstIdDel.Name = "txtInstIdDel";
            txtInstIdDel.Size = new Size(125, 23);
            txtInstIdDel.TabIndex = 55;
            txtInstIdDel.TextChanged += txtInstIdDel_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(815, 358);
            label14.Name = "label14";
            label14.Size = new Size(120, 25);
            label14.TabIndex = 56;
            label14.Text = "Instructor ID";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(861, 296);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 53;
            InsertUpdateButton.Text = "Insert / Update";
            InsertUpdateButton.UseVisualStyleBackColor = true;
            InsertUpdateButton.Click += InsertUpdateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.8F));
            tableLayoutPanel1.Controls.Add(label11, 0, 3);
            tableLayoutPanel1.Controls.Add(txtDeptID, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSalary, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDegree, 1, 1);
            tableLayoutPanel1.Controls.Add(txtInstName, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(818, 72);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(250, 218);
            tableLayoutPanel1.TabIndex = 52;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(3, 162);
            label11.Name = "label11";
            label11.Size = new Size(94, 40);
            label11.TabIndex = 32;
            label11.Text = "Department ID";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDeptID
            // 
            txtDeptID.Location = new Point(106, 165);
            txtDeptID.Name = "txtDeptID";
            txtDeptID.PlaceholderText = "NULL";
            txtDeptID.Size = new Size(114, 23);
            txtDeptID.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(3, 108);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 30;
            label10.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(106, 111);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "NULL";
            txtSalary.Size = new Size(114, 23);
            txtSalary.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(3, 54);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 28;
            label9.Text = "Degree";
            // 
            // txtDegree
            // 
            txtDegree.Location = new Point(106, 57);
            txtDegree.Name = "txtDegree";
            txtDegree.PlaceholderText = "NULL";
            txtDegree.Size = new Size(114, 23);
            txtDegree.TabIndex = 27;
            // 
            // txtInstName
            // 
            txtInstName.Location = new Point(106, 3);
            txtInstName.Name = "txtInstName";
            txtInstName.PlaceholderText = "NULL";
            txtInstName.Size = new Size(114, 23);
            txtInstName.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 40);
            label8.TabIndex = 25;
            label8.Text = "Instructor Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(254, 9);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 58;
            label16.Text = "Search And Display";
            // 
            // InstsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1099, 532);
            ControlBox = false;
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtInstIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label label15;
        private Button DeleteButton;
        private TextBox txtInstIdDel;
        private Label label14;
        private Button InsertUpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private TextBox txtDeptID;
        private Label label10;
        private TextBox txtSalary;
        private Label label9;
        private TextBox txtDegree;
        private TextBox txtInstName;
        private Label label8;
        private Label label16;
    }
}