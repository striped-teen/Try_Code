using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Try_Code
{
    /// <summary>
    /// Логика взаимодействия для Win_A_Z.xaml
    /// </summary>
    public partial class Win_A_Z : Window
    {
        public Win_A_Z()
        {
            InitializeComponent();
            loadContent();
        }

        private void loadContent()
        {
            ContentPanel.Orientation = Orientation.Horizontal;
            Button btnAll = new Button
            {
                BorderBrush = null,
                Background = null,
                Content = "Все",
                Margin = new Thickness(5, 0, 5, 0),
                FontSize = 16
            };
            ContentPanel.Children.Add(btnAll);

            for (char i = 'A'; i <= 'Z'; i++)
            {
                Button btn = new Button
                {
                    BorderBrush = null,
                    Background = null,
                    Content = i,
                    Margin = new Thickness(5, 0, 5, 0),
                    FontSize = 16,
                    Width = 18
                };
                ContentPanel.Children.Add(btn);
            }
        }
    }
}
