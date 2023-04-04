namespace SIN
{
    partial class Screen
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
            tabs = new TabControl();
            tabGenerate = new TabPage();
            generateButton = new Button();
            sinLabel = new Label();
            sinTextBox = new TextBox();
            planLabel = new Label();
            planTextbox = new TextBox();
            tabHistory = new TabPage();
            removeLabel = new Label();
            RemoveTextBox = new TextBox();
            removeButton = new Button();
            listBox = new ListBox();
            tabs.SuspendLayout();
            tabGenerate.SuspendLayout();
            tabHistory.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tabGenerate);
            tabs.Controls.Add(tabHistory);
            tabs.Location = new Point(0, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(447, 452);
            tabs.TabIndex = 0;
            // 
            // tabGenerate
            // 
            tabGenerate.BackColor = Color.OldLace;
            tabGenerate.BackgroundImageLayout = ImageLayout.Center;
            tabGenerate.Controls.Add(generateButton);
            tabGenerate.Controls.Add(sinLabel);
            tabGenerate.Controls.Add(sinTextBox);
            tabGenerate.Controls.Add(planLabel);
            tabGenerate.Controls.Add(planTextbox);
            tabGenerate.Location = new Point(4, 24);
            tabGenerate.Name = "tabGenerate";
            tabGenerate.Padding = new Padding(3);
            tabGenerate.Size = new Size(439, 424);
            tabGenerate.TabIndex = 0;
            tabGenerate.Text = "Generate";
            // 
            // generateButton
            // 
            generateButton.Location = new Point(178, 145);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(114, 23);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateButton_Click;
            // 
            // sinLabel
            // 
            sinLabel.AutoSize = true;
            sinLabel.Location = new Point(147, 177);
            sinLabel.Name = "sinLabel";
            sinLabel.Size = new Size(25, 15);
            sinLabel.TabIndex = 3;
            sinLabel.Text = "SIN";
            // 
            // sinTextBox
            // 
            sinTextBox.Location = new Point(178, 174);
            sinTextBox.Name = "sinTextBox";
            sinTextBox.Size = new Size(114, 23);
            sinTextBox.TabIndex = 2;
            // 
            // planLabel
            // 
            planLabel.AutoSize = true;
            planLabel.Location = new Point(142, 64);
            planLabel.Name = "planLabel";
            planLabel.Size = new Size(30, 15);
            planLabel.TabIndex = 1;
            planLabel.Text = "Plan";
            // 
            // planTextbox
            // 
            planTextbox.Location = new Point(178, 61);
            planTextbox.Name = "planTextbox";
            planTextbox.PlaceholderText = "Add plan number";
            planTextbox.Size = new Size(114, 23);
            planTextbox.TabIndex = 0;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(removeLabel);
            tabHistory.Controls.Add(RemoveTextBox);
            tabHistory.Controls.Add(removeButton);
            tabHistory.Controls.Add(listBox);
            tabHistory.Location = new Point(4, 24);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(439, 424);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "History";
            tabHistory.UseVisualStyleBackColor = true;
            tabHistory.Click += HistoryTab_Click;
            // 
            // removeLabel
            // 
            removeLabel.AutoSize = true;
            removeLabel.Location = new Point(297, 290);
            removeLabel.Name = "removeLabel";
            removeLabel.Size = new Size(102, 15);
            removeLabel.TabIndex = 3;
            removeLabel.Text = "Remove sin codes";
            // 
            // RemoveTextBox
            // 
            RemoveTextBox.Location = new Point(297, 319);
            RemoveTextBox.Name = "RemoveTextBox";
            RemoveTextBox.Size = new Size(100, 23);
            RemoveTextBox.TabIndex = 2;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(297, 357);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButton_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(0, 28);
            listBox.Name = "listBox";
            listBox.Size = new Size(245, 394);
            listBox.TabIndex = 0;
            listBox.DrawItem += DrawItem;
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.ScrollAlwaysVisible = true;
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(tabs);
            Name = "Screen";
            Text = "SIN";
            tabs.ResumeLayout(false);
            tabGenerate.ResumeLayout(false);
            tabGenerate.PerformLayout();
            tabHistory.ResumeLayout(false);
            tabHistory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabs;
        private TabPage tabGenerate;
        private TabPage tabHistory;
        private TextBox planTextbox;
        private Label planLabel;
        private Label sinLabel;
        private TextBox sinTextBox;
        private Button generateButton;
        private Button removeButton;
        private ListBox listBox;
        private TextBox RemoveTextBox;
        private Label removeLabel;
    }
}