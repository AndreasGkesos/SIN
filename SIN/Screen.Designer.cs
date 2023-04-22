using System.Runtime.Versioning;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            tabs = new TabControl();
            tabGenerate = new TabPage();
            certificateLabel = new Label();
            certificateTextBox = new TextBox();
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
            tabs.Size = new Size(481, 452);
            tabs.TabIndex = 0;
            tabs.Selected += Tabs_Selected;
            // 
            // tabGenerate
            // 
            tabGenerate.BackColor = Color.GhostWhite;
            tabGenerate.BackgroundImageLayout = ImageLayout.Center;
            tabGenerate.Controls.Add(certificateLabel);
            tabGenerate.Controls.Add(certificateTextBox);
            tabGenerate.Controls.Add(generateButton);
            tabGenerate.Controls.Add(sinLabel);
            tabGenerate.Controls.Add(sinTextBox);
            tabGenerate.Controls.Add(planLabel);
            tabGenerate.Controls.Add(planTextbox);
            tabGenerate.Location = new Point(4, 24);
            tabGenerate.Name = "tabGenerate";
            tabGenerate.Padding = new Padding(3);
            tabGenerate.Size = new Size(473, 424);
            tabGenerate.TabIndex = 0;
            tabGenerate.Text = "Generate";
            // 
            // certificateLabel
            // 
            certificateLabel.AutoSize = true;
            certificateLabel.Location = new Point(111, 206);
            certificateLabel.Name = "certificateLabel";
            certificateLabel.Size = new Size(61, 15);
            certificateLabel.TabIndex = 6;
            certificateLabel.Text = "Certificate";
            // 
            // certificateTextBox
            // 
            certificateTextBox.Location = new Point(178, 203);
            certificateTextBox.Name = "certificateTextBox";
            certificateTextBox.Size = new Size(114, 23);
            certificateTextBox.TabIndex = 5;
            certificateTextBox.Click += certificateTextBox_Click;
            // 
            // generateButton
            // 
            generateButton.Enabled = false;
            generateButton.Location = new Point(178, 136);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(114, 32);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = false;
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
            sinTextBox.Click += SinTextBox_Click;
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
            planTextbox.TextChanged += PlanTextbox_TextChanged;
            // 
            // tabHistory
            // 
            tabHistory.BackColor = Color.GhostWhite;
            tabHistory.Controls.Add(removeLabel);
            tabHistory.Controls.Add(RemoveTextBox);
            tabHistory.Controls.Add(removeButton);
            tabHistory.Controls.Add(listBox);
            tabHistory.Location = new Point(4, 24);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(473, 424);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "History";
            // 
            // removeLabel
            // 
            removeLabel.AutoSize = true;
            removeLabel.Location = new Point(362, 301);
            removeLabel.Name = "removeLabel";
            removeLabel.Size = new Size(102, 15);
            removeLabel.TabIndex = 3;
            removeLabel.Text = "Remove sin codes";
            // 
            // RemoveTextBox
            // 
            RemoveTextBox.Location = new Point(364, 319);
            RemoveTextBox.Name = "RemoveTextBox";
            RemoveTextBox.Size = new Size(100, 23);
            RemoveTextBox.TabIndex = 2;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(362, 359);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButton_Click;
            // 
            // listBox
            // 
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(0, 19);
            listBox.Name = "listBox";
            listBox.ScrollAlwaysVisible = true;
            listBox.Size = new Size(356, 379);
            listBox.TabIndex = 0;
            listBox.DrawItem += DrawItem;
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(tabs);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private Label certificateLabel;
        private TextBox certificateTextBox;
    }
}