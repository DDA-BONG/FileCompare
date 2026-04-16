namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            btnLeftDir = new Button();
            txtLeftDir = new TextBox();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            name_left = new ColumnHeader();
            size_left = new ColumnHeader();
            date_left = new ColumnHeader();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            panel6 = new Panel();
            name_right = new ColumnHeader();
            size_right = new ColumnHeader();
            date_right = new ColumnHeader();
            panel5 = new Panel();
            btnRightDir = new Button();
            txtRightDir = new TextBox();
            panel4 = new Panel();
            btnCopyFromRight = new Button();
            lvwRightDir = new ListView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1018, 601);
            splitContainer1.SplitterDistance = 519;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLeftDir);
            panel2.Controls.Add(txtLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 82);
            panel2.TabIndex = 1;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Location = new Point(422, 21);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(94, 29);
            btnLeftDir.TabIndex = 1;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(16, 22);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(397, 27);
            txtLeftDir.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(519, 480);
            panel3.TabIndex = 1;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { name_left, size_left, date_left });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(16, 82);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(496, 380);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            lvwLeftDir.SelectedIndexChanged += lvwLeftDir_SelectedIndexChanged;
            // 
            // name_left
            // 
            name_left.Text = "이름";
            name_left.Width = 200;
            // 
            // size_left
            // 
            size_left.Text = "크기";
            size_left.Width = 100;
            // 
            // date_left
            // 
            date_left.Text = "수정일";
            date_left.Width = 160;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 121);
            panel1.TabIndex = 0;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(418, 51);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(87, 41);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("휴먼둥근헤드라인", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.ActiveCaption;
            lblAppName.Location = new Point(16, 28);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(346, 41);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // panel6
            // 
            panel6.Controls.Add(lvwRightDir);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(495, 398);
            panel6.TabIndex = 2;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwRightDir.AutoArrange = false;
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { name_right, size_right, date_right });
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(17, 0);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(464, 380);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // name_right
            // 
            name_right.Text = "이름";
            name_right.Width = 200;
            // 
            // size_right
            // 
            size_right.Text = "크기";
            size_right.Width = 100;
            // 
            // date_right
            // 
            date_right.Text = "수정일";
            date_right.Width = 160;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRightDir);
            panel5.Controls.Add(txtRightDir);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(495, 78);
            panel5.TabIndex = 1;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRightDir.Location = new Point(394, 20);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(94, 29);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(17, 20);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(365, 27);
            txtRightDir.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCopyFromRight);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(495, 125);
            panel4.TabIndex = 0;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(17, 51);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(94, 41);
            btnCopyFromRight.TabIndex = 2;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 611);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "File Compare v1.0";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnLeftDir;
        private TextBox txtLeftDir;
        private ListView lvwRightDir;
        private ListView lvwLeftDir;
        private Button btnCopyFromLeft;
        private Label lblAppName;
        private Button btnRightDir;
        private TextBox txtRightDir;
        private Button btnCopyFromRight;
        private ColumnHeader name_left;
        private ColumnHeader size_left;
        private ColumnHeader date_left;
        private ColumnHeader name_right;
        private ColumnHeader size_right;
        private ColumnHeader date_right;
    }
}
