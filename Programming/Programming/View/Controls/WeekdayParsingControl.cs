using System;
using System.Windows.Forms;
using Programming.Model;


namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по парсингу дней недели из перечисления.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="WeekdayParsingControl"/>.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse(textWeekdayTextBox, out weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int) weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого для недели";
            }
        }
    }
}