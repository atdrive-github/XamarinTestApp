using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;
using TestApp.View;

namespace TestApp.ViewModel
{
    public class DetailsViewModel : ViewModelBase
    {
        #region Constructor
        public DetailsViewModel()
        {
            WorkingTechnology = new ObservableCollection<Technology>
            {
                new Technology(){ Name = "Microsoft .Net Development", Description = "The great thing about “our way” of creating Solutions in .Net is that the products have a very stable Architectural Backbone, they are Highly Scalable, Maintainable for the Upcoming Decades plus the Object Orientation Concepts are consumed in such a way that the Development is Quick and Stable, ensuring the Quality and Speed in the development at the same time."},
                new Technology(){ Name = "Mobile Development Services", Description = "Our mobile solutions are designed to create unique user experiences that reflect the values, priorities, and vision of client businesses. We help our clients achieve their business goals and work towards satisfying their long-term needs, expectations, and user requirements, which extend beyond any specific technology or implementation strategy. Our mobility experts help devise vigorous, next generation mobile solutions that address critical challenges such as those related to development of applications and managing tools, standardization of mobile applications, seamless deployment and upgrades, data encryption and privacy."},
                new Technology(){ Name = "PaaS / IaaS Development", Description = "We provide “out of the box” solutions for PaaS (Platform as a service)  and IaaS (Infrastructure as a Service) based application development to implement your very own SaaS models. We are experts in building the products on the frameworks of the cloud giants. "},
            };   
            
        }
        #endregion

        #region  Properties

        private ObservableCollection<Technology> _workingTechnology;
        public ObservableCollection<Technology> WorkingTechnology
        {
            get { return _workingTechnology; }
            set
            {
                _workingTechnology = value;

                OnPropertyChanged(() => WorkingTechnology);
            }
        }
       
        #endregion

    }
}
