using System;
using LocaCar.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LocaCar.Models;
    

namespace LocaCar
{
    /// <summary>
    /// Interação lógica para UserControlCarros.xam
    /// </summary>
    public partial class UserControlMenuItem : UserControl
    {
        TelaPrincipal _context;
        public UserControlMenuItem(ItemMenu itemMenu, TelaPrincipal context)
        {
            InitializeComponent();

            _context = context;

            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
     
        }
        public void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.SwitchScreen(((SubItem)((ListView)sender).SelectedItem).Screen);
        }
    }
}
