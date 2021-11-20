using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;


namespace BeautySaloonMVC.Controller
{
    public interface IProductView
    {
        void SetController(ProductController controller);
        void Clear();
        void Show(Product product);
        string Title { get; set; }
        double Cost { get; set; }
        string IsActive { get; set; }

    }
}
