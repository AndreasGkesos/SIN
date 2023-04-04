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

        private void HistoryTab_Click(object sender, EventArgs e)
        {
            GetHistory();
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
                        sinsWithSeperator.Add(new Sin { Code = "---------" });
                        sinsWithSeperator.Add(s);
                        previous = s.PlanNumber;
                    }
                }

                listBox.Items.Clear();

                foreach (var s in sinsWithSeperator)
                {
                    listBox.Items.Insert(0, string.Join("\t", s.Code, s.PlanNumber));
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox.SelectedItem.ToString().Split("\t")[0]);
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
    }
}