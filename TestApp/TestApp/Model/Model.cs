using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model
{
    public class AppPage
    {
        public Type PageType { set; get; }
        public string PageName { set; get; }

    }
    public class Technology
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Verticals
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
