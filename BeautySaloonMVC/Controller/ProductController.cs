using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;

namespace BeautySaloonMVC.Controller
{
    public class ProductController
    {
        IProductView view;
        IMainView mainView;
        Product product;
        public bool isActive { get; set; }

        public ProductController(IProductView _view, IMainView m, Product product)
        {
            this.view = _view;
            this.mainView = m;
            this.product = product;
            _view.SetController(this);
        }

        public void Load()
        {
            this.view.Title = product.Title;
            this.view.Cost = product.Cost;
            this.view.IsActive = product.IsActive;
        }

        private void updateUserWithViewValues(Product product)
        {
            product.Title = this.view.Title;
            product.Cost = this.view.Cost;
            product.IsActive = this.view.IsActive;

        }

        public Product GetProduct()
        {
            return product;
        }
        public IMainView MainView
        {
            get { return mainView; }
        }
    }
}
