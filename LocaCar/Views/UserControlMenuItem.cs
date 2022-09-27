using LocaCar.Models;
using System.Windows;

namespace LocaCar.Views
{
    internal class UserControlMenuItem : UIElement
    {
        private ItemMenu item6;
        private TelaPrincipal telaPrincipal;

        public UserControlMenuItem(ItemMenu item6, TelaPrincipal telaPrincipal)
        {
            this.item6 = item6;
            this.telaPrincipal = telaPrincipal;
        }
    }
}