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
            BackButton = new Button();
            StdGView = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            HireDateBox = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)StdGView).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FloralWhite;
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackButton.ForeColor = Color.Indigo;
            BackButton.Location = new Point(-1, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(63, 33);
            BackButton.TabIndex = 2;
            BackButton.Text = "<<Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StdGView
            // 
            StdGView.BackgroundColor = SystemColors.ControlLight;
            StdGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StdGView.Location = new Point(37, 281);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(336, 106);
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
            label5.Location = new Point(357, 63);
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
            label6.Location = new Point(358, 22);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 32;
            label6.Text = "Location";
            // 
            // HireDateBox
            // 
            HireDateBox.Location = new Point(514, 103);
            HireDateBox.Name = "HireDateBox";
            HireDateBox.Size = new Size(125, 23);
            HireDateBox.TabIndex = 25;
            HireDateBox.TextChanged += HireDateBox_TextChanged;
            // 
            // ManagerTBox
            // 
            ManagerTBox.Location = new Point(451, 64);
            ManagerTBox.Name = "ManagerTBox";
            ManagerTBox.Size = new Size(125, 23);
            ManagerTBox.TabIndex = 27;
            ManagerTBox.TextChanged += ManagerTBox_TextChanged;
            // 
            // LocTBox
            // 
            LocTBox.Location = new Point(451, 22);
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
            label3.Location = new Point(80, 102);
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
            label2.Location = new Point(101, 60);
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
            label1.Location = new Point(113, 21);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 22;
            label1.Text = "ID";
            // 
            // DescTBox
            // 
            DescTBox.Location = new Point(175, 102);
            DescTBox.Name = "DescTBox";
            DescTBox.Size = new Size(125, 23);
            DescTBox.TabIndex = 21;
            DescTBox.TextChanged += DescTBox_TextChanged;
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(175, 60);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 20;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(175, 18);
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
            RestButton.Location = new Point(682, 232);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(87, 33);
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
            DistButton.Text = "Distinct Stud";
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
            LstButton.Text = "Last Student";
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
            FstButton.Text = "First Student";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // DeptsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 523);
            ControlBox = false;
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
            Name = "DeptsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeptsForm";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private DataGridView StdGView;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox HireDateBox;
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
    }
}