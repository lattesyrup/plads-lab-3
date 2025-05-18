namespace trees.Forms;
#nullable disable

public partial class ArrayEnterForm : Form
{
    public int[] Array { get; private set; }

    public ArrayEnterForm() => InitializeComponent();

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        bool canClose = true;

        Array = new int[ArrayGrid.Rows.Count - 1];
        for (int i = 0; i < ArrayGrid.Rows.Count - 1; i++)
            if (int.TryParse(ArrayGrid.Rows[i].Cells["column"].Value.ToString(), out int res))
                Array[i] = res;
            else
            {
                MessageBox.Show($"Текст в строке {i} не соответствует формату числа.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                canClose = false;
            }

        if (canClose) Close();
    }

    private void ResetButton_Click(object sender, EventArgs e) => ArrayGrid.Rows.Clear();

    private void ArrayEnterForm_Load(object sender, EventArgs e) => ArrayGrid.Rows.Clear();
}
