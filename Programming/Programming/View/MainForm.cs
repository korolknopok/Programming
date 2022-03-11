using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Array season = System.Enum.GetValues(typeof(Season));
            foreach (Season value in season)
            {
                SeasonNamesComboBox.Items.Add(value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;
            Array initValues = System.Enum.GetValues(typeof(Enums));
            foreach (Enums value in initValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    enumValues = System.Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Weekday:
                    enumValues = System.Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Season:
                    enumValues = System.Enum.GetValues(typeof(Season));
                    break;
                case Enums.Manufactures:
                    enumValues = System.Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Genre:
                    enumValues = System.Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    enumValues = System.Enum.GetValues(typeof(EducationForm));
                    break;
                default:
                    throw new NotImplementedException();
            }
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            ValueWeekdayBox.Text = ((int) item).ToString();
        }


        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            if (System.Enum.TryParse(textWeekdayTextBox, out Weekday weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int) weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого для недели";
            }
        }

        private void GOButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!»");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}