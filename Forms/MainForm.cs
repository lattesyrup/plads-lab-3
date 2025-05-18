using Microsoft.VisualBasic;
using trees.Classes;
using TreeNode = trees.Classes.TreeNode;
namespace trees.Forms;

public partial class MainForm : Form
{
    private readonly AboutForm about = new();
    private readonly ArrayEnterForm arrayEnter = new();
    private readonly BinaryTree tree = new();
    private CycledDoubleLinkedList
        greaterList, lessList;
    private readonly List<Label> treeLabels = new();

    #region form methods

    public MainForm() => InitializeComponent();

    private void ExitMSItem_Click(object sender, EventArgs e) => Close();

    private void AboutMSItem_Click(object sender, EventArgs e)
    {
        Hide();
        about.ShowDialog();
        Show();
    }

    private void MainForm_FormClosing(object senter, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите выйти?", "Выход",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
            e.Cancel = true;
    }

    #endregion

    #region tree methods
    
    private void CreateTree(object sender, EventArgs e)
    {
        tree.root = tree.CreateBalanced(GetArray().Order().ToArray());

        int h = 100;
        int w = (Width - 2 * GreaterListBox.Width) / 2;
        // (h, w) - position of root
        ShowTree(tree.root, h, w);
        
        SwitchCreateDeleteEnabled();
        TaskPerformMSItem.Enabled = true;
    }

    private void ClearTree(object sender, EventArgs e)
    {
        ClearListBoxes();
        ClearLabels();
        SwitchCreateDeleteEnabled();
    }

    private void TaskPerformMSItem_Click(object sender, EventArgs e)
    {
        if (tree.root is null)
            MessageBox.Show("Дерево не создано.", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            int splitNum = GetNumber("число для разбиения");
            SplitNumberLabel.Text += splitNum.ToString();
            (lessList, greaterList) = tree.TaskFilter(splitNum);
            ShowListBoxes();
        }
        TaskPerformMSItem.Enabled = false;
    }

    #endregion

    #region draw methods

    private void ShowTree(TreeNode root, int top, int left)
    {
        const int delta_h = 30;
        int delta_w = (int)(
            (Width - 2 * GreaterListBox.Width) /
            Math.Pow(2, (top - 100) / delta_h + 2.5)
        );

        if (root != null)
        {
            CreateLabel(root.info, top, left);
            ShowTree(root.left, top + delta_h, left - delta_w);
            ShowTree(root.right, top + delta_h, left + delta_w);
        }
    }

    private void CreateLabel(int info, int top, int left)
    {
        Label l = new();
        l.Text = info.ToString();
        l.AutoSize = true;
        l.BackColor = Color.Transparent;
        l.BorderStyle = BorderStyle.FixedSingle;
        
        l.Update();
        l.Location = new Point(
            left - l.Width / 2,
            top - l.Height / 2
        );

        l.Visible = true;
        this.Controls.Add(l);
        treeLabels.Add(l);
    }

    private void ClearLabels()
    {
        foreach (Label l in treeLabels)
        {
            this.Controls.Remove(l);
            l.Dispose();
        }
        treeLabels.Clear();
    }

    private void ShowListBoxes()
    {
        greaterList.FillListBox(GreaterListBox);
        lessList.FillListBox(LessListBox);

        GreaterListBox.Visible = true;
        GreaterLabel.Visible = true;
        LessListBox.Visible = true;
        LessLabel.Visible = true;
        SplitNumberLabel.Visible = true;
    }

    private void ClearListBoxes()
    {
        GreaterListBox.Visible = false;
        GreaterLabel.Visible = false;
        LessListBox.Visible = false;
        LessLabel.Visible = false;
        SplitNumberLabel.Visible = false;
        
        GreaterListBox.Items.Clear();
        LessListBox.Items.Clear();
        SplitNumberLabel.Text = "Число для разбиения: ";
    }

    private void SwitchCreateDeleteEnabled()
    {
        CreateTreeMSItem.Enabled = !CreateTreeMSItem.Enabled;
        ClearTreeMSItem.Enabled = !ClearTreeMSItem.Enabled;
    }

    #endregion

    #region input methods

    private int[] GetArray()
    {
        do arrayEnter.ShowDialog();
        while (arrayEnter.Array == null);
        return arrayEnter.Array;
    }

    private int GetNumber(string prompt)
    {
        string input = Interaction.InputBox("Введите число для разбиения:", "Ввод числа");
        int res;
        while (!int.TryParse(input, out res))
        {
            MessageBox.Show("Текст не соответствует формату числа. Повторите ввод.", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            input = Interaction.InputBox("Введите число для разбиения:", "Ввод числа");
        }
        return res;
    }

    #endregion
}
