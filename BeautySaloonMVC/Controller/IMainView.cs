using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Controller;
using BeautySaloonMVC.Model;

namespace BeautySaloonMVC.Controller
{
    public interface IMainView
    {
        void SetController(MainController controller);
        void Clear();
        void AddProduct(Product product);
        void UpdateWithChangedMatirial(Product product);
    }
}
