namespace DEPI
{
    partial class InstCrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstCrsForm));
            BackButton = new Button();
            StdGView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            CrsIdTBox = new TextBox();
            InstIdTBox = new TextBox();
            ShowDetailButton = new Button();
            RestButton = new Button();
            DistButton = new Button();
            LstButton = new Button();
            FstButton = new Button();
            label3 = new Label();
            EvalTBox = new TextBox();
            label16 = new Label();
            label15 = new Label();
            DeleteButton = new Button();
            txtInstIdDel = new TextBox();
            label14 = new Label();
            InsertUpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            txtEvalu = new TextBox();
            label9 = new Label();
            txtCrsID = new TextBox();
            txtInstID = new TextBox();
            label8 = new Label();
            txtCrsIDDel = new TextBox();
            label4 = new Label();
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
            StdGView.Location = new Point(35, 256);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 3;
            StdGView.RowStateChanged += StdGView_RowStateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(123, 114);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 89;
            label2.Text = "Course ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(114, 77);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 88;
            label1.Text = "Instructor ID";
            // 
            // CrsIdTBox
            // 
            CrsIdTBox.Location = new Point(219, 111);
            CrsIdTBox.Name = "CrsIdTBox";
            CrsIdTBox.Size = new Size(125, 23);
            CrsIdTBox.TabIndex = 87;
            CrsIdTBox.TextChanged += CrsIdTBox_TextChanged;
            // 
            // InstIdTBox
            // 
            InstIdTBox.Location = new Point(219, 77);
            InstIdTBox.Name = "InstIdTBox";
            InstIdTBox.Size = new Size(125, 23);
            InstIdTBox.TabIndex = 86;
            InstIdTBox.TextChanged += InstIdTBox_TextChanged;
            // 
            // ShowDetailButton
            // 
            ShowDetailButton.Font = new Font("Segoe UI", 10F);
            ShowDetailButton.Location = new Point(303, 165);
            ShowDetailButton.Name = "ShowDetailButton";
            ShowDetailButton.Size = new Size(185, 30);
            ShowDetailButton.TabIndex = 84;
            ShowDetailButton.Text = "Show More Details";
            ShowDetailButton.UseVisualStyleBackColor = true;
            ShowDetailButton.Click += ShowDetailButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(680, 210);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
            RestButton.TabIndex = 83;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(262, 210);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 82;
            DistButton.Text = "Distinct Rec";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(149, 210);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 85;
            LstButton.Text = "Last Record";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(35, 210);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 81;
            FstButton.Text = "First Record";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(376, 93);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 91;
            label3.Text = "Evaluation";
            // 
            // EvalTBox
            // 
            EvalTBox.Location = new Point(464, 92);
            EvalTBox.Name = "EvalTBox";
            EvalTBox.Size = new Size(125, 23);
            EvalTBox.TabIndex = 90;
            EvalTBox.TextChanged += EvalTBox_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(249, 17);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 98;
            label16.Text = "Search And Display";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(783, 17);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 97;
            label15.Text = "Make Changes On Database";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(885, 382);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 94;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtInstIdDel
            // 
            txtInstIdDel.Location = new Point(931, 303);
            txtInstIdDel.Name = "txtInstIdDel";
            txtInstIdDel.Size = new Size(125, 23);
            txtInstIdDel.TabIndex = 95;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(805, 300);
            label14.Name = "label14";
            label14.Size = new Size(120, 25);
            label14.TabIndex = 96;
            label14.Text = "Instructor ID";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(853, 237);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 93;
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
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(txtEvalu, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCrsID, 1, 1);
            tableLayoutPanel1.Controls.Add(txtInstID, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(805, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(268, 166);
            tableLayoutPanel1.TabIndex = 92;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(3, 110);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 30;
            label10.Text = "Evaluation";
            // 
            // txtEvalu
            // 
            txtEvalu.Location = new Point(117, 113);
            txtEvalu.Name = "txtEvalu";
            txtEvalu.PlaceholderText = "NULL";
            txtEvalu.Size = new Size(114, 23);
            txtEvalu.TabIndex = 29;
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
            txtCrsID.Location = new Point(117, 58);
            txtCrsID.Name = "txtCrsID";
            txtCrsID.PlaceholderText = "NULL";
            txtCrsID.Size = new Size(114, 23);
            txtCrsID.TabIndex = 27;
            // 
            // txtInstID
            // 
            txtInstID.Location = new Point(117, 3);
            txtInstID.Name = "txtInstID";
            txtInstID.PlaceholderText = "NULL";
            txtInstID.Size = new Size(114, 23);
            txtInstID.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 25;
            label8.Text = "Instructor ID";
            // 
            // txtCrsIDDel
            // 
            txtCrsIDDel.Location = new Point(931, 342);
            txtCrsIDDel.Name = "txtCrsIDDel";
            txtCrsIDDel.Size = new Size(125, 23);
            txtCrsIDDel.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(814, 339);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 100;
            label4.Text = "Course ID";
            // 
            // InstCrsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 508);
            ControlBox = false;
            Controls.Add(txtCrsIDDel);
            Controls.Add(label4);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtInstIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(EvalTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CrsIdTBox);
            Controls.Add(InstIdTBox);
            Controls.Add(ShowDetailButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InstCrsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Courses";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private DataGridView StdGView;
        private Label label2;
        private Label label1;
        private TextBox CrsIdTBox;
        private TextBox InstIdTBox;
        private Button ShowDetailButton;
        private Button RestButton;
        private Button DistButton;
        private Button LstButton;
        private Button FstButton;
        private Label label3;
        private TextBox EvalTBox;
        private Label label16;
        private Label label15;
        private Button DeleteButton;
        private TextBox txtInstIdDel;
        private Label label14;
        private Button InsertUpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private TextBox txtEvalu;
        private Label label9;
        private TextBox txtCrsID;
        private TextBox txtInstID;
        private Label label8;
        private TextBox txtCrsIDDel;
        private Label label4;
    }
}