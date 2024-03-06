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
                if (IsInFilterType(item))
                {
                    var splits = Regex.Split(item, @"\\");
                    splits[splits.Length - 1] = Regex.Replace(Regex.Split(item, @"\\").Last(), textBoxPattern.Text, textBoxReplace.Text);
                    renamePlan[i] = string.Join(@"\\", splits);
                }
                else
                    renamePlan[i] = item;

            }

            string[] shows = new string[renamePlan.Length];
            for (int i = 0; i < renamePlan.Length; i++)
            {
                if (renamePlan[i] == null) continue;
                var splits = Regex.Split(renamePlan[i], @"\\");
                shows[i] = splits.Last();
            }
            //labelPreview.Text = string.Join("\r\n", shows);
            listBoxPlan.Items.Clear();
            listBoxPlan.Items.AddRange(shows);
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < containFiles.Length; i++)
            {
                var item = containFiles[i];
                if (System.IO.File.Exists(renamePlan[i]) && IsInFilterType(item))
                    list.Add(renamePlan[i] + "Exist");
            }
            if (list.Count > 0)
                MessageBox.Show($"{string.Join("\r\n", list)}", "File already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool IsInFilterType(string item)
        {
            return Regex.Match(item, textBoxFileType.Text + @"$").Success;
        }
        private void listBoxPlan_Move(object sender, EventArgs e)
        {
            listBoxFiles.TopIndex = listBoxPlan.TopIndex;
        }

        private void buttonGetNumber_Click(object sender, EventArgs e)
        {
            string pattern1 = @".*?(\d+)\)?";
            string replace1 = @"00$1";
            string pattern2 = @"0*(\d{3})";
            string replace2 = @"$1";
            for (int i = 0; i < containFiles.Length; i++)
            {
                var item = containFiles[i];
                if (IsInFilterType(item))
                {
                    var splits = Regex.Split(item, @"\\");
                    item = Regex.Replace(Regex.Split(item, @"\\").Last(), pattern1, replace1);
                    item = Regex.Replace(Regex.Split(item, @"\\").Last(), pattern2, replace2);
                    splits[splits.Length - 1] = item;
                    renamePlan[i] = string.Join(@"\\", splits);
                }
                else
                    renamePlan[i] = item;
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

        private void buttonExtensionPreset_Click(object sender, EventArgs e)
        {
            textBoxFileType.Text = "(png|jpg|gif)";
        }
    }
}