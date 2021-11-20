using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Controller;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.View;

namespace BeautySaloonMVC
{
    public partial class MainView : Form, IMainView
    {
        MainController controller;
        List<ProductView> pviews;
        int n = 6;


        public MainView()
        {
            InitializeComponent();

            pviews = new List<ProductView>();
        }
        public void AddProduct(Product product)
        {
            ProductView productView = new ProductView(product);
            ProductController productController = new ProductController(productView, this, product);
            productView.Show(product);
            this.MainLayoutPanel.Controls.Add(productView);
            pviews.Add(productView);
            controller.LoadView(n);
        }
        public void Clear()
        {
            this.MainLayoutPanel.Controls.Clear();
        }
        public void SetController(MainController _controller)
        {
            controller = _controller;
        }
        public void UpdateWithChangedMatirial(Product product)
        {
            throw new NotImplementedException();
        }

    }
}
