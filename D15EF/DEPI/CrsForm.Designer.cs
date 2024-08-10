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
            BackButton.TabIndex = 1;
            BackButton.Text = "<<Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StdGView
            // 
            StdGView.BackgroundColor = SystemColors.ControlLight;
            StdGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StdGView.Location = new Point(33, 287);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 240);
            StdGView.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(367, 63);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 67;
            label5.Text = "Topic ID";
            // 
            // TopicTBox
            // 
            TopicTBox.Location = new Point(458, 65);
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
            label3.Location = new Point(367, 22);
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
            label2.Location = new Point(104, 64);
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
            label1.Location = new Point(116, 25);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 62;
            label1.Text = "ID";
            // 
            // DurationTBox
            // 
            DurationTBox.Location = new Point(458, 22);
            DurationTBox.Name = "DurationTBox";
            DurationTBox.Size = new Size(125, 23);
            DurationTBox.TabIndex = 61;
            DurationTBox.TextChanged += DurationTBox_TextChanged;
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(171, 64);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 60;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(171, 22);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 59;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowStudButton
            // 
            ShowStudButton.Font = new Font("Segoe UI", 10F);
            ShowStudButton.Location = new Point(475, 190);
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
            ShowInstsButton.Location = new Point(248, 190);
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
            ShowTopicButton.Location = new Point(33, 190);
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
            RestButton.Location = new Point(678, 236);
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
            DistButton.Location = new Point(260, 236);
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
            LstButton.Location = new Point(147, 236);
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
            FstButton.Location = new Point(33, 236);
            FstButton.Name = "FstButton";
            FstButton.Size = new Size(87, 33);
            FstButton.TabIndex = 52;
            FstButton.Text = "First Course";
            FstButton.UseVisualStyleBackColor = true;
            FstButton.Click += FstButton_Click;
            // 
            // CrsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 530);
            ControlBox = false;
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
            Name = "CrsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)StdGView).EndInit();
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
    }
}