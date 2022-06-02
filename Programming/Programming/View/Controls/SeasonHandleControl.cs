using System;
using System.Windows.Forms;
using Programming.Model;



namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по изменению цвета фона окна и выплывающих сообщений. 
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
            
            Array seasons = Enum.GetValues(typeof(Season));
            foreach (Season value in seasons)
            {
                SeasonNamesComboBox.Items.Add(value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;
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
                    this.BackColor = AppColors.Spring;
                    break;
                case Season.Autumn:
                    this.BackColor = AppColors.Autumn;
                    break;
            }
        }
    }
}