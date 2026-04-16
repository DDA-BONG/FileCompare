namespace FileCompare
{
    public partial class Form1 : Form
    {
        private readonly Color defaultItemColor = Color.Black;
        private readonly Color newerItemColor = Color.Red;
        private readonly Color olderItemColor = Color.Gray;
        private readonly Color missingItemColor = Color.Purple;

        public Form1()
        {
            InitializeComponent();
        }

        private void PopulateListView(ListView? listView, string folderPath)
        {
            if (listView is null || string.IsNullOrWhiteSpace(folderPath))
            {
                return;
            }

            listView.BeginUpdate();
            listView.Items.Clear();

            try
            {
                var directories = Directory.EnumerateDirectories(folderPath)
                    .Select(path => new DirectoryInfo(path))
                    .OrderBy(directory => directory.Name, StringComparer.OrdinalIgnoreCase);

                foreach (var directory in directories)
                {
                    var item = new ListViewItem(directory.Name);
                    item.SubItems.Add(GetDirectorySizeText(directory));
                    item.SubItems.Add(directory.LastWriteTime.ToString("g"));
                    item.Tag = directory;
                    item.ForeColor = defaultItemColor;
                    listView.Items.Add(item);
                }

                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("지정한 폴더를 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, "입출력 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(this, "폴더 접근 권한이 없습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listView.EndUpdate();
            }

            ApplyComparisonColors();
        }

        private static string GetDirectorySizeText(DirectoryInfo directory)
        {
            try
            {
                long totalBytes = directory.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
                return FormatSize(totalBytes);
            }
            catch
            {
                return "-";
            }
        }

        private static string FormatSize(long bytes)
        {
            string[] units = ["B", "KB", "MB", "GB", "TB"];
            double size = bytes;
            int unitIndex = 0;

            while (size >= 1024 && unitIndex < units.Length - 1)
            {
                size /= 1024;
                unitIndex++;
            }

            return $"{size:0.##} {units[unitIndex]}";
        }

        private void ApplyComparisonColors()
        {
            if (lvwLeftDir is null || lvwRightDir is null)
            {
                return;
            }

            ResetItemColors(lvwLeftDir);
            ResetItemColors(lvwRightDir);

            if (!CanCompareDirectories())
            {
                return;
            }

            var rightItemsByName = lvwRightDir.Items
                .Cast<ListViewItem>()
                .Where(item => !string.IsNullOrWhiteSpace(item.Text))
                .ToDictionary(item => item.Text, StringComparer.OrdinalIgnoreCase);

            foreach (ListViewItem leftItem in lvwLeftDir.Items)
            {
                if (string.IsNullOrWhiteSpace(leftItem.Text))
                {
                    continue;
                }

                if (!rightItemsByName.TryGetValue(leftItem.Text, out var rightItem))
                {
                    leftItem.ForeColor = missingItemColor;
                    continue;
                }

                ApplyMatchedItemColors(leftItem, rightItem);
            }

            var leftNames = lvwLeftDir.Items
                .Cast<ListViewItem>()
                .Where(item => !string.IsNullOrWhiteSpace(item.Text))
                .Select(item => item.Text)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (ListViewItem rightItem in lvwRightDir.Items)
            {
                if (!string.IsNullOrWhiteSpace(rightItem.Text) && !leftNames.Contains(rightItem.Text))
                {
                    rightItem.ForeColor = missingItemColor;
                }
            }
        }

        private bool CanCompareDirectories()
        {
            return !string.IsNullOrWhiteSpace(txtLeftDir.Text)
                && Directory.Exists(txtLeftDir.Text)
                && !string.IsNullOrWhiteSpace(txtRightDir.Text)
                && Directory.Exists(txtRightDir.Text);
        }

        private void ResetItemColors(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                item.ForeColor = defaultItemColor;
            }
        }

        private void ApplyMatchedItemColors(ListViewItem leftItem, ListViewItem rightItem)
        {
            if (leftItem.Tag is not DirectoryInfo leftDirectory || rightItem.Tag is not DirectoryInfo rightDirectory)
            {
                return;
            }

            if (leftItem.SubItems.Count < 2 || rightItem.SubItems.Count < 2)
            {
                return;
            }

            bool sameSize = string.Equals(leftItem.SubItems[1].Text, rightItem.SubItems[1].Text, StringComparison.OrdinalIgnoreCase);
            bool sameDate = leftDirectory.LastWriteTime == rightDirectory.LastWriteTime;

            if (sameSize && sameDate)
            {
                return;
            }

            if (leftDirectory.LastWriteTime > rightDirectory.LastWriteTime)
            {
                leftItem.ForeColor = newerItemColor;
                rightItem.ForeColor = olderItemColor;
            }
            else if (leftDirectory.LastWriteTime < rightDirectory.LastWriteTime)
            {
                leftItem.ForeColor = olderItemColor;
                rightItem.ForeColor = newerItemColor;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            dlg.Description = "폴더를 선택하세요.";

            if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
            {
                dlg.SelectedPath = txtLeftDir.Text;
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLeftDir.Text = dlg.SelectedPath;
                PopulateListView(lvwLeftDir, dlg.SelectedPath);
            }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            dlg.Description = "폴더를 선택하세요.";

            if (!string.IsNullOrWhiteSpace(txtRightDir.Text) && Directory.Exists(txtRightDir.Text))
            {
                dlg.SelectedPath = txtRightDir.Text;
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRightDir.Text = dlg.SelectedPath;
                PopulateListView(lvwRightDir, dlg.SelectedPath);
            }
        }

        private void lvwLeftDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
