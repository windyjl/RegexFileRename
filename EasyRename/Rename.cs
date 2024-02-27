using System.Text.RegularExpressions;

namespace EasyRename
{
    public partial class Form1 : Form
    {
        string[] containFiles;
        string[] renamePlan;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath.Text = fbd.SelectedPath;
                    containFiles = Directory.GetFiles(fbd.SelectedPath);
                    renamePlan = new string[containFiles.Length];
                    SetupLabelFiles();
                }
            }
        }

        private void SetupLabelFiles()
        {
            string[] shows = new string[containFiles.Length];
            for (int i = 0; i < containFiles.Length; i++)
            {
                var splits = Regex.Split(containFiles[i], @"\\");
                shows[i] = splits.Last();
            }
            //labelFiles.Text = string.Join("\r\n", shows);
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(shows);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < containFiles.Length; i++)
            {
                var item = containFiles[i];
                var splits = Regex.Split(item, @"\\");
                splits[splits.Length - 1] = Regex.Replace(Regex.Split(item, @"\\").Last(), textBoxPattern.Text, textBoxReplace.Text);
                renamePlan[i] = string.Join(@"\\", splits);
            }

            string[] shows = new string[renamePlan.Length];
            for (int i = 0; i < renamePlan.Length; i++)
            {
                var splits = Regex.Split(renamePlan[i], @"\\");
                shows[i] = splits.Last();
            }
            //labelPreview.Text = string.Join("\r\n", shows);
            listBoxPlan.Items.Clear();
            listBoxPlan.Items.AddRange(shows);
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < containFiles.Length; i++)
            {
                var item = containFiles[i];
                System.IO.File.Move(item, renamePlan[i]);
            }
        }

        private void listBoxPlan_Move(object sender, EventArgs e)
        {
            listBoxFiles.TopIndex = listBoxPlan.TopIndex;
        }
    }
}