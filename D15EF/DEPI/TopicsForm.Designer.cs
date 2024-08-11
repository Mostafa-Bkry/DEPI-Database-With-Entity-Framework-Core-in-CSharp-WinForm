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
            StdGView.Location = new Point(34, 228);
            StdGView.Name = "StdGView";
            StdGView.Size = new Size(732, 261);
            StdGView.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(294, 71);
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
            label1.Location = new Point(306, 32);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 78;
            label1.Text = "ID";
            // 
            // NameTBox
            // 
            NameTBox.Location = new Point(361, 71);
            NameTBox.Name = "NameTBox";
            NameTBox.Size = new Size(125, 23);
            NameTBox.TabIndex = 76;
            NameTBox.TextChanged += NameTBox_TextChanged;
            // 
            // IdTBox
            // 
            IdTBox.Location = new Point(361, 29);
            IdTBox.Name = "IdTBox";
            IdTBox.Size = new Size(125, 23);
            IdTBox.TabIndex = 75;
            IdTBox.TextChanged += IdTBox_TextChanged;
            // 
            // ShowTopicButton
            // 
            ShowTopicButton.Font = new Font("Segoe UI", 10F);
            ShowTopicButton.Location = new Point(306, 134);
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
            // TopicsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 496);
            ControlBox = false;
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
    }
}