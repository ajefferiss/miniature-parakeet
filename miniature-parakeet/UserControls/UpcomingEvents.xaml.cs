using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace miniature_parakeet.UserControls
{
    /// <summary>
    /// Interaction logic for UpcomingEvents.xaml
    /// </summary>
    public partial class UpcomingEvents : UserControl
    {
        public UpcomingEvents()
        {
            InitializeComponent();

            for (int x = 0; x < 50; x++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Content = "Hello " + x;
                UpcomingPlannerItems.Items.Add(listViewItem);
            }
        }
    }
}
