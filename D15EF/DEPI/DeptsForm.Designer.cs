namespace DEPI
{
    partial class DeptsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptsForm));
            BackButton = new Button();
            StdGView = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ManagerTBox = new TextBox();
            LocTBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DescTBox = new TextBox();
            NameTBox = new TextBox();
            IdTBox = new TextBox();
            ShowInstButton = new Button();
            ShowStudButton = new Button();
            ShowManagerButton = new Button();
            RestButton = new Button();
            DistButton = new Button();
            LstButton = new Button();
            FstButton = new Button();
            label15 = new Label();
            DeleteButton = new Button();
            txtDeptIdDel = new TextBox();
            label14 = new Label();
            InsertUpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtHireDate = new TextBox();
            label7 = new Label();
            label11 = new Label();
            txtManager = new TextBox();
            label10 = new Label();
            txtLocation = new TextBox();
            label9 = new Label();
            txtDescription = new TextBox();
            txtDeptName = new TextBox();
            label8 = new Label();
            label16 = new Label();
            HireDateBox = new TextBox();
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
            StdGView.Location = new Point(37, 281);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(752, 240);
            StdGView.TabIndex = 3;
            StdGView.RowStateChanged += StdGView_RowStateChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(339, 145);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 29;
            label4.Text = "Manager Hiring Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(360, 102);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 31;
            label5.Text = "Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(361, 61);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 32;
            label6.Text = "Location";
            // 
            // ManagerTBox
            // 
            ManagerTBox.Location = new Point(454, 103);
            ManagerTBox.Name = "ManagerTBox";
            ManagerTBox.Size = new Size(125, 23);
            ManagerTBox.TabIndex = 27;
            ManagerTBox.TextChanged += ManagerTBox_TextChanged;
            // 
            // LocTBox
            // 
            LocTBox.Location = new Point(454, 61);
            LocTBox.Name = "LocTBox";
            LocTBox.Size = new Size(125, 23);
            LocTBox.TabIndex = 28;
            LocTBox.TextChanged += LocTBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(83, 141);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 23;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(104, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(116, 60);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 22;
            label1.Text = "ID";
            // 
            // DescTBox
            // 
            DescTBox.Location = new Point(178, 141);
            DescTBox.Name = "DescTBox";
            DescTBox.Size = new Size(125, 23);
            DescTBox.TabIndex = 21;
            DescTBox.TextChanged += DescTBox_TextChanged;
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(178, 99);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 20;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(178, 57);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 19;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowInstButton
            // 
            ShowInstButton.Font = new Font("Segoe UI", 10F);
            ShowInstButton.Location = new Point(479, 186);
            ShowInstButton.Name = "ShowInstButton";
            ShowInstButton.Size = new Size(198, 30);
            ShowInstButton.TabIndex = 17;
            ShowInstButton.Text = "Show Dept Instructors";
            ShowInstButton.UseVisualStyleBackColor = true;
            ShowInstButton.Click += ShowInstButton_Click;
            // 
            // ShowStudButton
            // 
            ShowStudButton.Font = new Font("Segoe UI", 10F);
            ShowStudButton.Location = new Point(252, 186);
            ShowStudButton.Name = "ShowStudButton";
            ShowStudButton.Size = new Size(198, 30);
            ShowStudButton.TabIndex = 16;
            ShowStudButton.Text = "Show Department Students";
            ShowStudButton.UseVisualStyleBackColor = true;
            ShowStudButton.Click += ShowStudButton_Click;
            // 
            // ShowManagerButton
            // 
            ShowManagerButton.Font = new Font("Segoe UI", 10F);
            ShowManagerButton.Location = new Point(37, 186);
            ShowManagerButton.Name = "ShowManagerButton";
            ShowManagerButton.Size = new Size(185, 30);
            ShowManagerButton.TabIndex = 15;
            ShowManagerButton.Text = "Show Dept Managers";
            ShowManagerButton.UseVisualStyleBackColor = true;
            ShowManagerButton.Click += ShowManagerButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(695, 232);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(94, 33);
            RestButton.TabIndex = 14;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(264, 232);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 13;
            DistButton.Text = "Distinct Dept";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(151, 232);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 18;
            LstButton.Text = "Last Dept";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(37, 232);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 12;
            FstButton.Text = "First Dept";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(831, 9);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 45;
            label15.Text = "Make Changes On Database";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(933, 418);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 42;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtDeptIdDel
            // 
            txtDeptIdDel.Location = new Point(994, 389);
            txtDeptIdDel.Name = "txtDeptIdDel";
            txtDeptIdDel.Size = new Size(125, 23);
            txtDeptIdDel.TabIndex = 43;
            txtDeptIdDel.TextChanged += txtStIdDel_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(837, 387);
            label14.Name = "label14";
            label14.Size = new Size(139, 25);
            label14.TabIndex = 44;
            label14.Text = "Department ID";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(902, 335);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 41;
            InsertUpdateButton.Text = "Insert / Update";
            InsertUpdateButton.UseVisualStyleBackColor = true;
            InsertUpdateButton.Click += InsertUpdateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.57028F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.429718F));
            tableLayoutPanel1.Controls.Add(txtHireDate, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 3);
            tableLayoutPanel1.Controls.Add(txtManager, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(txtLocation, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDescription, 1, 1);
            tableLayoutPanel1.Controls.Add(txtDeptName, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(857, 57);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(250, 261);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // txtHireDate
            // 
            txtHireDate.Location = new Point(109, 211);
            txtHireDate.Name = "txtHireDate";
            txtHireDate.PlaceholderText = "NULL";
            txtHireDate.Size = new Size(114, 23);
            txtHireDate.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(3, 208);
            label7.Name = "label7";
            label7.Size = new Size(89, 40);
            label7.TabIndex = 34;
            label7.Text = "Manager Hiring Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(3, 156);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 32;
            label11.Text = "Manager ID";
            // 
            // txtManager
            // 
            txtManager.Location = new Point(109, 159);
            txtManager.Name = "txtManager";
            txtManager.PlaceholderText = "NULL";
            txtManager.Size = new Size(114, 23);
            txtManager.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(3, 104);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 30;
            label10.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(109, 107);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "NULL";
            txtLocation.Size = new Size(114, 23);
            txtLocation.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(3, 52);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 28;
            label9.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(109, 55);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "NULL";
            txtDescription.Size = new Size(114, 23);
            txtDescription.TabIndex = 27;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(109, 3);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.PlaceholderText = "NULL";
            txtDeptName.Size = new Size(114, 23);
            txtDeptName.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 25;
            label8.Text = "Dept Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(264, 9);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 46;
            label16.Text = "Search And Display";
            // 
            // HireDateBox
            // 
            HireDateBox.Location = new Point(517, 142);
            HireDateBox.Name = "HireDateBox";
            HireDateBox.Size = new Size(125, 23);
            HireDateBox.TabIndex = 25;
            HireDateBox.TextChanged += HireDateBox_TextChanged;
            // 
            // DeptsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1146, 523);
            ControlBox = false;
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtDeptIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(HireDateBox);
            Controls.Add(ManagerTBox);
            Controls.Add(LocTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescTBox);
            Controls.Add(NameTBox);
            Controls.Add(IdTBox);
            Controls.Add(ShowInstButton);
            Controls.Add(ShowStudButton);
            Controls.Add(ShowManagerButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeptsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private DataGridView StdGView;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ManagerTBox;
        private TextBox LocTBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DescTBox;
        private TextBox NameTBox;
        private TextBox IdTBox;
        private Button ShowInstButton;
        private Button ShowStudButton;
        private Button ShowManagerButton;
        private Button RestButton;
        private Button DistButton;
        private Button LstButton;
        private Button FstButton;
        private Label label15;
        private Button DeleteButton;
        private TextBox txtDeptIdDel;
        private Label label14;
        private Button InsertUpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private TextBox txtManager;
        private Label label10;
        private TextBox txtLocation;
        private Label label9;
        private TextBox txtDescription;
        private TextBox txtDeptName;
        private Label label8;
        private Label label16;
        private Label label7;
        private TextBox HireDateBox;
        private TextBox txtHireDate;
    }
}