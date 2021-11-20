using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Controller;
using BeautySaloonMVC.Model;

namespace BeautySaloonMVC.Controller
{
    public class MainController
    {
        private IMainView _view;
        private IList<Product> _list;

        public MainController(IMainView view, IList<Product> list)
        {
            _view = view;
            _list = list;

            view.SetController(this);
        }

        public void LoadView(int n)
        {
            _view.Clear();

            for (int i = 0; i < n; i++)
            {
                //if (i < _list.Count - 1)
                    _view.AddProduct(_list[i]);
            }
        }





    }
}
