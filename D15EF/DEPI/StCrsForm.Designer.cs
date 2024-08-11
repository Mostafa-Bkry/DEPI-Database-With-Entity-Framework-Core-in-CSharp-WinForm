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
            ((System.ComponentModel.ISupportInitialize)StdGView).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FloralWhite;
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackButton.ForeColor = Color.Indigo;
            BackButton.Location = new Point(-1, -1);
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
            StdGView.Location = new Point(33, 249);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(281, 108);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 102;
            label3.Text = "Grade";
            // 
            // GradeTBox
            // 
            GradeTBox.Location = new Point(376, 109);
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
            label2.Location = new Point(270, 63);
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
            label1.Location = new Point(269, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 99;
            label1.Text = "Student ID";
            // 
            // CrsIdTBox
            // 
            CrsIdTBox.Location = new Point(376, 64);
            CrsIdTBox.Name = "CrsIdTBox";
            CrsIdTBox.Size = new Size(125, 23);
            CrsIdTBox.TabIndex = 98;
            CrsIdTBox.TextChanged += CrsIdTBox_TextChanged;
            // 
            // StIdTBox
            // 
            StIdTBox.Location = new Point(376, 22);
            StIdTBox.Name = "StIdTBox";
            StIdTBox.Size = new Size(125, 23);
            StIdTBox.TabIndex = 97;
            StIdTBox.TextChanged += StIdTBox_TextChanged;
            // 
            // ShowDetailButton
            // 
            ShowDetailButton.Font = new Font("Segoe UI", 10F);
            ShowDetailButton.Location = new Point(300, 155);
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
            // StCrsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 499);
            ControlBox = false;
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
    }
}