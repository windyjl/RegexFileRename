namespace EasyRename
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
            buttonBrowse = new Button();
            folderPath = new Label();
            labelList = new Label();
            labelFiles = new Label();
            textBoxPattern = new TextBox();
            textBoxReplace = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonReplace = new Button();
            buttonRename = new Button();
            labelPreview = new Label();
            label4 = new Label();
            listBoxFiles = new ListBox();
            listBoxPlan = new ListBox();
            buttonGetNumber = new Button();
            labelPreset = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            labelFileType = new Label();
            textBoxFileType = new TextBox();
            SuspendLayout();
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(12, 15);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 0;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += button1_Click;
            // 
            // folderPath
            // 
            folderPath.AutoSize = true;
            folderPath.Location = new Point(93, 18);
            folderPath.Name = "folderPath";
            folderPath.Size = new Size(34, 17);
            folderPath.TabIndex = 1;
            folderPath.Text = "path";
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Location = new Point(12, 92);
            labelList.Name = "labelList";
            labelList.Size = new Size(57, 17);
            labelList.TabIndex = 2;
            labelList.Text = "FindFiles";
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.Location = new Point(12, 123);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(43, 51);
            labelFiles.TabIndex = 3;
            labelFiles.Text = "label3\r\n123\r\n123\r\n";
            // 
            // textBoxPattern
            // 
            textBoxPattern.Location = new Point(415, 15);
            textBoxPattern.Name = "textBoxPattern";
            textBoxPattern.Size = new Size(100, 23);
            textBoxPattern.TabIndex = 4;
            // 
            // textBoxReplace
            // 
            textBoxReplace.Location = new Point(578, 15);
            textBoxReplace.Name = "textBoxReplace";
            textBoxReplace.Size = new Size(100, 23);
            textBoxReplace.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 6;
            label1.Text = "pattern";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 18);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 7;
            label2.Text = "replace";
            // 
            // buttonReplace
            // 
            buttonReplace.Location = new Point(699, 15);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(75, 23);
            buttonReplace.TabIndex = 8;
            buttonReplace.Text = "Replace";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // buttonRename
            // 
            buttonRename.Location = new Point(699, 44);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(75, 23);
            buttonRename.TabIndex = 9;
            buttonRename.Text = "Rename";
            buttonRename.UseVisualStyleBackColor = true;
            buttonRename.Click += buttonRename_Click;
            // 
            // labelPreview
            // 
            labelPreview.AutoSize = true;
            labelPreview.Location = new Point(358, 123);
            labelPreview.Name = "labelPreview";
            labelPreview.Size = new Size(43, 17);
            labelPreview.TabIndex = 10;
            labelPreview.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 92);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 11;
            label4.Text = "RenamePlan";
            // 
            // listBoxFiles
            // 
            listBoxFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 17;
            listBoxFiles.Location = new Point(12, 123);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(320, 225);
            listBoxFiles.TabIndex = 12;
            // 
            // listBoxPlan
            // 
            listBoxPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxPlan.FormattingEnabled = true;
            listBoxPlan.ItemHeight = 17;
            listBoxPlan.Location = new Point(358, 123);
            listBoxPlan.Name = "listBoxPlan";
            listBoxPlan.Size = new Size(320, 225);
            listBoxPlan.TabIndex = 13;
            // 
            // buttonGetNumber
            // 
            buttonGetNumber.Location = new Point(415, 50);
            buttonGetNumber.Name = "buttonGetNumber";
            buttonGetNumber.Size = new Size(100, 23);
            buttonGetNumber.TabIndex = 14;
            buttonGetNumber.Text = "GetNumber";
            buttonGetNumber.UseVisualStyleBackColor = true;
            buttonGetNumber.Click += buttonGetNumber_Click;
            // 
            // labelPreset
            // 
            labelPreset.AutoSize = true;
            labelPreset.Location = new Point(358, 53);
            labelPreset.Name = "labelPreset";
            labelPreset.Size = new Size(45, 17);
            labelPreset.TabIndex = 15;
            labelPreset.Text = "preset";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(161, 92);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 21);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "jpg";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(213, 92);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(42, 21);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "gif";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(105, 91);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 21);
            checkBox3.TabIndex = 18;
            checkBox3.Text = "png";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelFileType
            // 
            labelFileType.AutoSize = true;
            labelFileType.Location = new Point(15, 56);
            labelFileType.Name = "labelFileType";
            labelFileType.Size = new Size(54, 17);
            labelFileType.TabIndex = 20;
            labelFileType.Text = "file type";
            // 
            // textBoxFileType
            // 
            textBoxFileType.Location = new Point(72, 53);
            textBoxFileType.Name = "textBoxFileType";
            textBoxFileType.Size = new Size(213, 23);
            textBoxFileType.TabIndex = 19;
            textBoxFileType.Text = "(png|jpg|gif)";
            // 
            // Form1
            // 
            AcceptButton = buttonReplace;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 379);
            Controls.Add(labelFileType);
            Controls.Add(textBoxFileType);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(labelPreset);
            Controls.Add(buttonGetNumber);
            Controls.Add(listBoxPlan);
            Controls.Add(listBoxFiles);
            Controls.Add(label4);
            Controls.Add(labelPreview);
            Controls.Add(buttonRename);
            Controls.Add(buttonReplace);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxReplace);
            Controls.Add(textBoxPattern);
            Controls.Add(labelFiles);
            Controls.Add(labelList);
            Controls.Add(folderPath);
            Controls.Add(buttonBrowse);
            Name = "Form1";
            Text = "RegexFileRename";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button buttonBrowse;
        private Label folderPath;
        private Label labelList;
        private Label labelFiles;
        private TextBox textBoxPattern;
        private TextBox textBoxReplace;
        private Label label1;
        private Label label2;
        private Button buttonReplace;
        private Button buttonRename;
        private Label labelPreview;
        private Label label4;
        private ListBox listBoxFiles;
        private ListBox listBoxPlan;
        private Button buttonGetNumber;
        private Label labelPreset;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label labelFileType;
        private TextBox textBoxFileType;
    }
}
