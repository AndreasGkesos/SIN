using DB.Models;
using SinHandler;

namespace SIN
{
    public partial class Screen : Form
    {
        private ISinHandler _handler { get; set; }
        public Screen(ISinHandler gerenate)
        {
            InitializeComponent();
            _handler = gerenate;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var sin = _handler.Generate(planTextbox.Text);
            sinTextBox.Text = sin;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _handler.RemovePerPlan(RemoveTextBox.Text);
            GetHistory();
        }

        private void Tabs_Selected(object sender, EventArgs e)
        {
            if (((TabControlEventArgs)e).TabPage.Text == "History") GetHistory();
        }

        private void GetHistory()
        {
            var sins = _handler.GetAll();

            var sinsWithSeperator = new List<Sin>();

            if (sins.FirstOrDefault() != null)
            {
                var previous = sins.FirstOrDefault().PlanNumber;
                foreach (var s in sins)
                {
                    if (previous == s.PlanNumber) sinsWithSeperator.Add(s);
                    else
                    {
                        sinsWithSeperator.Add(new Sin { Code = "- - - - - - - -" });
                        sinsWithSeperator.Add(s);
                        previous = s.PlanNumber;
                    }
                }

                listBox.Items.Clear();
                listBox.Items.Add(string.Empty);
                foreach (var sin in sinsWithSeperator.Select(x => string.Join("\t", x.Code, x.PlanNumber)).ToList())
                {
                    listBox.Items.Add(sin);
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(!string.IsNullOrWhiteSpace(listBox.SelectedItem as string) ? listBox.SelectedItem.ToString().Split("\t")[0] : " ");
        }

        private void DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            FontStyle fontStyle = FontStyle.Regular;
            fontStyle = FontStyle.Bold;
            if (listBox.Items.Count > 0 && e.Index > 0)
            {
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), new Font("Arial", 14, fontStyle), Brushes.Black, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void SinTextBox_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sinTextBox.Text);
        }

        private void PlanTextbox_TextChanged(object sender, EventArgs e)
        {
            generateButton.Enabled = planTextbox.Text.Length == 3;
        }
    }
}