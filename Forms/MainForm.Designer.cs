namespace trees.Forms;

partial class MainForm
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
        MS = new MenuStrip();
        TaskMSItem = new ToolStripMenuItem();
        CreateTreeMSItem = new ToolStripMenuItem();
        TaskPerformMSItem = new ToolStripMenuItem();
        ClearTreeMSItem = new ToolStripMenuItem();
        AboutMSItem = new ToolStripMenuItem();
        ExitToolStripMenuItem = new ToolStripMenuItem();
        LessListBox = new ListBox();
        GreaterListBox = new ListBox();
        LessLabel = new Label();
        GreaterLabel = new Label();
        SplitNumberLabel = new Label();
        MS.SuspendLayout();
        SuspendLayout();
        // 
        // MS
        // 
        MS.ImageScalingSize = new Size(24, 24);
        MS.Items.AddRange(new ToolStripItem[] { TaskMSItem, AboutMSItem, ExitToolStripMenuItem });
        MS.Location = new Point(0, 0);
        MS.Name = "MS";
        MS.Size = new Size(1028, 33);
        MS.TabIndex = 0;
        MS.Text = "Menu Strip";
        // 
        // TaskMSItem
        // 
        TaskMSItem.DropDownItems.AddRange(new ToolStripItem[] { CreateTreeMSItem, TaskPerformMSItem, ClearTreeMSItem });
        TaskMSItem.Name = "TaskMSItem";
        TaskMSItem.Size = new Size(95, 29);
        TaskMSItem.Text = "Задание";
        // 
        // CreateTreeMSItem
        // 
        CreateTreeMSItem.Name = "CreateTreeMSItem";
        CreateTreeMSItem.Size = new Size(267, 34);
        CreateTreeMSItem.Text = "Создание дерева";
        CreateTreeMSItem.Click += CreateTree;
        // 
        // TaskPerformMSItem
        // 
        TaskPerformMSItem.Enabled = false;
        TaskPerformMSItem.Name = "TaskPerformMSItem";
        TaskPerformMSItem.Size = new Size(267, 34);
        TaskPerformMSItem.Text = "Обработка дерева";
        TaskPerformMSItem.Click += TaskPerformMSItem_Click;
        // 
        // ClearTreeMSItem
        // 
        ClearTreeMSItem.Enabled = false;
        ClearTreeMSItem.Name = "ClearTreeMSItem";
        ClearTreeMSItem.Size = new Size(267, 34);
        ClearTreeMSItem.Text = "Очистка дерева";
        ClearTreeMSItem.Click += ClearTree;
        // 
        // AboutMSItem
        // 
        AboutMSItem.Name = "AboutMSItem";
        AboutMSItem.Size = new Size(141, 29);
        AboutMSItem.Text = "О программе";
        AboutMSItem.Click += AboutMSItem_Click;
        // 
        // ExitToolStripMenuItem
        // 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
        ExitToolStripMenuItem.Size = new Size(80, 29);
        ExitToolStripMenuItem.Text = "Выход";
        ExitToolStripMenuItem.Click += ExitMSItem_Click;
        // 
        // LessListBox
        // 
        LessListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LessListBox.FormattingEnabled = true;
        LessListBox.Location = new Point(658, 36);
        LessListBox.Name = "LessListBox";
        LessListBox.Size = new Size(180, 329);
        LessListBox.TabIndex = 1;
        LessListBox.Visible = false;
        // 
        // GreaterListBox
        // 
        GreaterListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        GreaterListBox.FormattingEnabled = true;
        GreaterListBox.Location = new Point(844, 36);
        GreaterListBox.Name = "GreaterListBox";
        GreaterListBox.Size = new Size(180, 329);
        GreaterListBox.TabIndex = 2;
        GreaterListBox.Visible = false;
        // 
        // LessLabel
        // 
        LessLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LessLabel.AutoSize = true;
        LessLabel.FlatStyle = FlatStyle.System;
        LessLabel.Location = new Point(658, 368);
        LessLabel.Name = "LessLabel";
        LessLabel.Size = new Size(200, 25);
        LessLabel.TabIndex = 3;
        LessLabel.Text = "Узлы меньше / равные";
        LessLabel.Visible = false;
        // 
        // GreaterLabel
        // 
        GreaterLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        GreaterLabel.AutoSize = true;
        GreaterLabel.Location = new Point(905, 368);
        GreaterLabel.Name = "GreaterLabel";
        GreaterLabel.Size = new Size(119, 25);
        GreaterLabel.TabIndex = 4;
        GreaterLabel.Text = "Узлы больше";
        GreaterLabel.Visible = false;
        // 
        // SplitNumberLabel
        // 
        SplitNumberLabel.AutoSize = true;
        SplitNumberLabel.Location = new Point(658, 416);
        SplitNumberLabel.Name = "SplitNumberLabel";
        SplitNumberLabel.Size = new Size(195, 25);
        SplitNumberLabel.TabIndex = 5;
        SplitNumberLabel.Text = "Число для разбиения: ";
        SplitNumberLabel.Visible = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1028, 450);
        Controls.Add(SplitNumberLabel);
        Controls.Add(GreaterLabel);
        Controls.Add(LessLabel);
        Controls.Add(GreaterListBox);
        Controls.Add(LessListBox);
        Controls.Add(MS);
        MainMenuStrip = MS;
        Name = "MainForm";
        Text = "Л/р №3: Деревья";
        FormClosing += MainForm_FormClosing;
        MS.ResumeLayout(false);
        MS.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip MS;
    private ToolStripMenuItem TaskMSItem;
    private ToolStripMenuItem AboutMSItem;
    private ToolStripMenuItem ExitToolStripMenuItem;
    private ToolStripMenuItem CreateTreeMSItem;
    private ToolStripMenuItem TaskPerformMSItem;
    private ToolStripMenuItem ClearTreeMSItem;
    private ListBox LessListBox;
    private ListBox GreaterListBox;
    private Label LessLabel;
    private Label GreaterLabel;
    private Label SplitNumberLabel;
}
