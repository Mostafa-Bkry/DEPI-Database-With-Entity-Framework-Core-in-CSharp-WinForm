namespace DEPI
{
    partial class TopicsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicsForm));
            BackButton = new Button();
            StdGView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            NameTBox = new TextBox();
            IdTBox = new TextBox();
            ShowTopicButton = new Button();
            RestButton = new Button();
            DistButton = new Button();
            LstButton = new Button();
            FstButton = new Button();
            label15 = new Label();
            DeleteButton = new Button();
            txtTopicIdDel = new TextBox();
            label14 = new Label();
            InsertUpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTopicName = new TextBox();
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
            StdGView.Location = new Point(34, 228);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 261);
            StdGView.TabIndex = 3;
            StdGView.RowStateChanged += StdGView_RowStateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(208, 101);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 80;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(220, 62);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 78;
            label1.Text = "ID";
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(275, 101);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 76;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(275, 59);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 75;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowTopicButton
            // 
            ShowTopicButton.Font = new Font("Segoe UI", 10F);
            ShowTopicButton.Location = new Point(297, 147);
            ShowTopicButton.Name = "ShowTopicButton";
            ShowTopicButton.Size = new Size(185, 30);
            ShowTopicButton.TabIndex = 71;
            ShowTopicButton.Text = "Show Topic  Courses";
            ShowTopicButton.UseVisualStyleBackColor = true;
            ShowTopicButton.Click += ShowTopicButton_Click;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 9F);
            RestButton.Location = new Point(679, 189);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
            RestButton.TabIndex = 70;
            RestButton.Text = "Reset";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // DistButton
            // 
            DistButton.Font = new Font("Segoe UI", 9F);
            DistButton.Location = new Point(261, 189);
            DistButton.Name = "DistButton";
            DistButton.Size = new Size(87, 33);
            DistButton.TabIndex = 69;
            DistButton.Text = "Distinct Topic";
            DistButton.UseVisualStyleBackColor = true;
            DistButton.Click += DistButton_Click;
            // 
            // LstButton
            // 
            LstButton.Font = new Font("Segoe UI", 9F);
            LstButton.Location = new Point(148, 189);
            LstButton.Name = "LstButton";
            LstButton.Size = new Size(87, 33);
            LstButton.TabIndex = 74;
            LstButton.Text = "Last Topic";
            LstButton.UseVisualStyleBackColor = true;
            LstButton.Click += LstButton_Click;
            // 
            // FstButton
            // 
            FstButton.Font = new Font("Segoe UI", 9F);
            FstButton.Location = new Point(34, 189);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 68;
            FstButton.Text = "First Topic";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(811, 51);
            label15.Name = "label15";
            label15.Size = new Size(276, 28);
            label15.TabIndex = 86;
            label15.Text = "Make Changes On Database";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 11F);
            DeleteButton.Location = new Point(919, 262);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 33);
            DeleteButton.TabIndex = 83;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // txtTopicIdDel
            // 
            txtTopicIdDel.Location = new Point(946, 224);
            txtTopicIdDel.Name = "txtTopicIdDel";
            txtTopicIdDel.Size = new Size(125, 23);
            txtTopicIdDel.TabIndex = 84;
            txtTopicIdDel.TextChanged += txtTopicIdDel_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(850, 221);
            label14.Name = "label14";
            label14.Size = new Size(81, 25);
            label14.TabIndex = 85;
            label14.Text = "Topic ID";
            // 
            // InsertUpdateButton
            // 
            InsertUpdateButton.Font = new Font("Segoe UI", 11F);
            InsertUpdateButton.Location = new Point(885, 147);
            InsertUpdateButton.Name = "InsertUpdateButton";
            InsertUpdateButton.Size = new Size(154, 33);
            InsertUpdateButton.TabIndex = 82;
            InsertUpdateButton.Text = "Insert / Update";
            InsertUpdateButton.UseVisualStyleBackColor = true;
            InsertUpdateButton.Click += InsertUpdateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.9253731F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.0746269F));
            tableLayoutPanel1.Controls.Add(txtTopicName, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(838, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(268, 41);
            tableLayoutPanel1.TabIndex = 81;
            // 
            // txtTopicName
            // 
            txtTopicName.Location = new Point(110, 3);
            txtTopicName.Name = "txtTopicName";
            txtTopicName.PlaceholderText = "NULL";
            txtTopicName.Size = new Size(114, 23);
            txtTopicName.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 25;
            label8.Text = "Topic Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(297, 9);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 87;
            label16.Text = "Search And Display";
            // 
            // TopicsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 496);
            ControlBox = false;
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(DeleteButton);
            Controls.Add(txtTopicIdDel);
            Controls.Add(label14);
            Controls.Add(InsertUpdateButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameTBox);
            Controls.Add(IdTBox);
            Controls.Add(ShowTopicButton);
            Controls.Add(RestButton);
            Controls.Add(DistButton);
            Controls.Add(LstButton);
            Controls.Add(FstButton);
            Controls.Add(StdGView);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TopicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Topics";
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
        private TextBox NameTBox;
        private TextBox IdTBox;
        private Button ShowTopicButton;
        private Button RestButton;
        private Button DistButton;
        private Button LstButton;
        private Button FstButton;
        private Label label15;
        private Button DeleteButton;
        private TextBox txtTopicIdDel;
        private Label label14;
        private Button InsertUpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTopicName;
        private Label label8;
        private Label label16;
    }
}