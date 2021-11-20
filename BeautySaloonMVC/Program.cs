using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Controller;
using BeautySaloonMVC.View;
using BeautySaloonMVC.Model;


namespace BeautySaloonMVC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainView mainView = new MainView();
            mainView.Visible = false;
            List<Product> products = new List<Product>();
            using (Model1 db = new Model1())
            {
                products = db.Product.ToList();
            }
            MainController controller = new MainController(mainView, products);
            controller.LoadView(1);
            mainView.ShowDialog();
        }
    }
}
