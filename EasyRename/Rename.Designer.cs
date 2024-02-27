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
            folderPath.Location = new Point(12, 50);
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
            // Form1
            // 
            AcceptButton = buttonReplace;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 379);
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
    }
}
