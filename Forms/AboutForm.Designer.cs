namespace trees.Forms;

partial class AboutForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
        TaskLabel = new Label();
        AuthorLabel = new Label();
        SuspendLayout();
        // 
        // TaskLabel
        // 
        TaskLabel.AutoSize = true;
        TaskLabel.Location = new Point(16, 19);
        TaskLabel.Margin = new Padding(4, 0, 4, 0);
        TaskLabel.Name = "TaskLabel";
        TaskLabel.Size = new Size(711, 75);
        TaskLabel.TabIndex = 0;
        TaskLabel.Text = resources.GetString("TaskLabel.Text");
        // 
        // AuthorLabel
        // 
        AuthorLabel.AutoSize = true;
        AuthorLabel.Location = new Point(497, 177);
        AuthorLabel.Margin = new Padding(4, 0, 4, 0);
        AuthorLabel.Name = "AuthorLabel";
        AuthorLabel.Size = new Size(212, 75);
        AuthorLabel.TabIndex = 1;
        AuthorLabel.Text = "Выполнил Карбовничий\r\nГеннадий Вячеславович,\r\nгруппа 6102-090301D";
        // 
        // AboutForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(742, 279);
        Controls.Add(AuthorLabel);
        Controls.Add(TaskLabel);
        Margin = new Padding(4);
        Name = "AboutForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "О программе";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label TaskLabel;
    private Label AuthorLabel;
}