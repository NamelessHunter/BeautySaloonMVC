using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Controller;
using BeautySaloonMVC.Model;

namespace BeautySaloonMVC.View
{
    public partial class ProductView : UserControl, IProductView
    {
        ProductController controller;
        Product product;
        public ProductView(Product _product)
        {
            InitializeComponent();
            product = _product;
        }
        public void SetController(ProductController _controller)
        {
            controller = _controller;
        }
        public string Title 
        { 
            get { return this.labelProductName.Text; }
            set { this.labelProductName.Text = value; } 
        }
        public double Cost 
        {
            get { return double.Parse(this.labelCost.Text); }
            set { this.labelCost.Text = value.ToString(); }
        }
        public string IsActive 
        { 
            get { return this.labelActive.Text; }
            set { this.labelActive.Text = value; }
        }

        public void Clear()
        {
            this.labelProductName.Text = string.Empty;
            this.labelCost.Text = string.Empty;
            this.labelActive.Text = string.Empty;
        }

        public void Show(Product product)
        {
            this.labelProductName.Text = product.Title;
            this.labelCost.Text = product.Cost.ToString();
            this.labelActive.Text = product.IsActive;
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }
    }
}
