namespace DEPI
{
    partial class CrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrsForm));
            BackButton = new Button();
            StdGView = new DataGridView();
            label5 = new Label();
            TopicTBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DurationTBox = new TextBox();
            NameTBox = new TextBox();
            IdTBox = new TextBox();
            ShowStudButton = new Button();
            ShowInstsButton = new Button();
            ShowTopicButton = new Button();
            RestButton = new Button();
            DistButton = new Button();
            LstButton = new Button();
            FstButton = new Button();
            label15 = new Label();
            DeleteButton = new Button();
            txtCrsIdDel = new TextBox();
            label14 = new Label();
            InsertUpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            txtTopicID = new TextBox();
            label9 = new Label();
            txtDuration = new TextBox();
            txtCrsName = new TextBox();
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
            BackButton.TabIndex = 1;
            BackButton.Text = "<<Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StdGView
            // 
            StdGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StdGView.BackgroundColor = SystemColors.ControlLight;
            StdGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StdGView.Location = new Point(36, 246);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 2;
            StdGView.RowStateChanged += StdGView_RowStateChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(360, 100);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 67;
            label5.Text = "Topic ID";
            // 
            // TopicTBox
            // 
            TopicTBox.Location = new Point(451, 102);
            TopicTBox.Name = "TopicTBox";
            TopicTBox.Size = new Size(125, 23);
            TopicTBox.TabIndex = 65;
            TopicTBox.TextChanged += TopicTBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(360, 59);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 63;
            label3.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(97, 101);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 64;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(109, 62);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 62;
            label1.Text = "ID";
            // 
            // DurationTBox
            // 
            DurationTBox.Location = new Point(451, 59);
            DurationTBox.Name = "DurationTBox";
            DurationTBox.Size = new Size(125, 23);
            DurationTBox.TabIndex = 61;
            DurationTBox.TextChanged += DurationTBox_TextChanged;
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(164, 101);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 60;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(164, 59);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 59;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowStudButton
            // 
            ShowStudButton.Font = new Font("Segoe UI", 10F);
            ShowStudButton.Location = new Point(478, 149);
            ShowStudButton.Name = "ShowStudButton";
            ShowStudButton.Size = new Size(198, 30);
            ShowStudButton.TabIndex = 57;
            ShowStudButton.Text = "Show Course Students";
            ShowStudButton.UseVisualStyleBackColor = true;
            ShowStudButton.Click += ShowStudButton_Click;
            // 
            // ShowInstsButton
            // 
            ShowInstsButton.Font = new Font("Segoe UI", 10F);
            ShowInstsButton.Location = new Point(251, 149);
            ShowInstsButton.Name = "ShowInstsButton";
            ShowInstsButton.Size = new Size(198, 30);
            ShowInstsButton.TabIndex = 56;
            ShowInstsButton.Text = "Show Course Instructors";
            ShowInstsButton.UseVisualStyleBackColor = true;
            ShowInstsButton.Click += ShowInstsButton_Click;
            // 
            // ShowTopicButton
            // 
            ShowTopicButton.Font = new Font("Segoe UI", 10F);
            ShowTopicButton.Location = new Point(36, 149);
            ShowTopicButton.Name = "ShowTopicButton";
            ShowTopicButton.Size = new Size(185, 30);
            ShowTopicButton.TabIndex = 55;
            ShowTopicButton.Text = "Show Courses Topic";
            ShowTopicButton.UseVisualStyleBackColor = true;
            ShowTopicButton.Click += ShowManagedButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(681, 195);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
            RestButton.TabIndex = 54;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(263, 195);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 53;
            DistButton.Text = "Distinct Crs";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(150, 195);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 58;
            LstButton.Text = "Last Course";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(36, 195);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 52;
            FstButton.Text = "First Course";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(795, 14);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 73;
            label15.Text = "Make Changes On Database";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(896, 317);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 70;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtCrsIdDel
            // 
            txtCrsIdDel.Location = new Point(942, 288);
            txtCrsIdDel.Name = "txtCrsIdDel";
            txtCrsIdDel.Size = new Size(125, 23);
            txtCrsIdDel.TabIndex = 71;
            txtCrsIdDel.TextChanged += txtCrsIdDel_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(830, 285);
            label14.Name = "label14";
            label14.Size = new Size(94, 25);
            label14.TabIndex = 72;
            label14.Text = "Course ID";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(865, 234);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 69;
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
            tableLayoutPanel1.Controls.Add(txtTopicID, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDuration, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCrsName, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(817, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(268, 166);
            tableLayoutPanel1.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(3, 110);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 30;
            label10.Text = "Topic ID";
            // 
            // txtTopicID
            // 
            txtTopicID.Location = new Point(117, 113);
            txtTopicID.Name = "txtTopicID";
            txtTopicID.PlaceholderText = "NULL";
            txtTopicID.Size = new Size(114, 23);
            txtTopicID.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(3, 55);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 28;
            label9.Text = "Duration";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(117, 58);
            txtDuration.Name = "txtDuration";
            txtDuration.PlaceholderText = "NULL";
            txtDuration.Size = new Size(114, 23);
            txtDuration.TabIndex = 27;
            // 
            // txtCrsName
            // 
            txtCrsName.Location = new Point(117, 3);
            txtCrsName.Name = "txtCrsName";
            txtCrsName.PlaceholderText = "NULL";
            txtCrsName.Size = new Size(114, 23);
            txtCrsName.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 25;
            label8.Text = "Course Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(254, 14);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 74;
            label16.Text = "Search And Display";
            // 
            // CrsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1097, 491);
            ControlBox = false;
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtCrsIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(TopicTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DurationTBox);
            Controls.Add(NameTBox);
            Controls.Add(IdTBox);
            Controls.Add(ShowStudButton);
            Controls.Add(ShowInstsButton);
            Controls.Add(ShowTopicButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Courses";
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
        private TextBox TopicTBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DurationTBox;
        private TextBox NameTBox;
        private TextBox IdTBox;
        private Button ShowStudButton;
        private Button ShowInstsButton;
        private Button ShowTopicButton;
        private Button RestButton;
        private Button DistButton;
        private Button LstButton;
        private Button FstButton;
        private Label label15;
        private Button DeleteButton;
        private TextBox txtCrsIdDel;
        private Label label14;
        private Button InsertUpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private TextBox txtTopicID;
        private Label label9;
        private TextBox txtDuration;
        private TextBox txtCrsName;
        private Label label8;
        private Label label16;
    }
}