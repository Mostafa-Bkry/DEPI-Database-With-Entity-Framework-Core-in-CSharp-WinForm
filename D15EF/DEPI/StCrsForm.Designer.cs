namespace DEPI
{
    partial class StCrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StCrsForm));
            BackButton = new Button();
            StdGView = new DataGridView();
            label3 = new Label();
            GradeTBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CrsIdTBox = new TextBox();
            StIdTBox = new TextBox();
            ShowDetailButton = new Button();
            RestButton = new Button();
            DistButton = new Button();
            LstButton = new Button();
            FstButton = new Button();
            txtCrsIDDel = new TextBox();
            label4 = new Label();
            label16 = new Label();
            label15 = new Label();
            DeleteButton = new Button();
            txtStIdDel = new TextBox();
            label14 = new Label();
            InsertUpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtGrade = new TextBox();
            label9 = new Label();
            txtCrsID = new TextBox();
            txtStudID = new TextBox();
            label8 = new Label();
            label10 = new Label();
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
            StdGView.Location = new Point(33, 249);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 3;
            StdGView.RowStateChanged += StdGView_RowStateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(334, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 102;
            label3.Text = "Grade";
            // 
            // GradeTBox
            // 
            GradeTBox.Location = new Point(408, 88);
            GradeTBox.Name = "GradeTBox";
            GradeTBox.Size = new Size(125, 23);
            GradeTBox.TabIndex = 101;
            GradeTBox.TextChanged += GradeTBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(71, 104);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 100;
            label2.Text = "Course ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(70, 67);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 99;
            label1.Text = "Student ID";
            // 
            // CrsIdTBox
            // 
            CrsIdTBox.Location = new Point(177, 105);
            CrsIdTBox.Name = "CrsIdTBox";
            CrsIdTBox.Size = new Size(125, 23);
            CrsIdTBox.TabIndex = 98;
            CrsIdTBox.TextChanged += CrsIdTBox_TextChanged;
            // 
            // StIdTBox
            // 
            StIdTBox.Location = new Point(177, 67);
            StIdTBox.Name = "StIdTBox";
            StIdTBox.Size = new Size(125, 23);
            StIdTBox.TabIndex = 97;
            StIdTBox.TextChanged += StIdTBox_TextChanged;
            // 
            // ShowDetailButton
            // 
            ShowDetailButton.Font = new Font("Segoe UI", 10F);
            ShowDetailButton.Location = new Point(300, 165);
            ShowDetailButton.Name = "ShowDetailButton";
            ShowDetailButton.Size = new Size(185, 30);
            ShowDetailButton.TabIndex = 95;
            ShowDetailButton.Text = "Show More Details";
            ShowDetailButton.UseVisualStyleBackColor = true;
            ShowDetailButton.Click += ShowDetailButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(678, 210);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
            RestButton.TabIndex = 94;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(260, 210);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 93;
            DistButton.Text = "Distinct Rec";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(147, 210);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 96;
            LstButton.Text = "Last Record";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(33, 210);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 92;
            FstButton.Text = "First Record";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // txtCrsIDDel
            // 
            txtCrsIDDel.Location = new Point(946, 342);
            txtCrsIDDel.Name = "txtCrsIDDel";
            txtCrsIDDel.Size = new Size(125, 23);
            txtCrsIDDel.TabIndex = 110;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(829, 339);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 111;
            label4.Text = "Course ID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(242, 17);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 109;
            label16.Text = "Search And Display";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(798, 17);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 108;
            label15.Text = "Make Changes On Database";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(900, 382);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 105;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtStIdDel
            // 
            txtStIdDel.Location = new Point(946, 303);
            txtStIdDel.Name = "txtStIdDel";
            txtStIdDel.Size = new Size(125, 23);
            txtStIdDel.TabIndex = 106;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(820, 300);
            label14.Name = "label14";
            label14.Size = new Size(103, 25);
            label14.TabIndex = 107;
            label14.Text = "Student ID";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(873, 237);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 104;
            InsertUpdateButton.Text = "Insert / Update";
            InsertUpdateButton.UseVisualStyleBackColor = true;
            InsertUpdateButton.Click += InsertUpdateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.9403F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.0597F));
            tableLayoutPanel1.Controls.Add(txtGrade, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCrsID, 1, 1);
            tableLayoutPanel1.Controls.Add(txtStudID, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Location = new Point(830, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(268, 166);
            tableLayoutPanel1.TabIndex = 103;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(102, 113);
            txtGrade.Name = "txtGrade";
            txtGrade.PlaceholderText = "NULL";
            txtGrade.Size = new Size(114, 23);
            txtGrade.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(3, 55);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 28;
            label9.Text = "Course ID";
            // 
            // txtCrsID
            // 
            txtCrsID.Location = new Point(102, 58);
            txtCrsID.Name = "txtCrsID";
            txtCrsID.PlaceholderText = "NULL";
            txtCrsID.Size = new Size(114, 23);
            txtCrsID.TabIndex = 27;
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(102, 3);
            txtStudID.Name = "txtStudID";
            txtStudID.PlaceholderText = "NULL";
            txtStudID.Size = new Size(114, 23);
            txtStudID.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 25;
            label8.Text = "Student ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(3, 110);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 30;
            label10.Text = "Grade";
            // 
            // StCrsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 499);
            ControlBox = false;
            Controls.Add(txtCrsIDDel);
            Controls.Add(label4);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtStIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(GradeTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CrsIdTBox);
            Controls.Add(StIdTBox);
            Controls.Add(ShowDetailButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StCrsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students Courses";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private DataGridView StdGView;
        private Label label3;
        private TextBox GradeTBox;
        private Label label2;
        private Label label1;
        private TextBox CrsIdTBox;
        private TextBox StIdTBox;
        private Button ShowDetailButton;
        private Button RestButton;
        private Button DistButton;
        private Button LstButton;
        private Button FstButton;
        private TextBox txtCrsIDDel;
        private Label label4;
        private Label label16;
        private Label label15;
        private Button DeleteButton;
        private TextBox txtStIdDel;
        private Label label14;
        private Button InsertUpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private TextBox txtGrade;
        private Label label9;
        private TextBox txtCrsID;
        private TextBox txtStudID;
        private Label label8;
    }
}