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
    public class VerticalsViewModel : ViewModelBase
    {
        #region Constructor
        public VerticalsViewModel()
        {
            IndustryVerticals = new ObservableCollection<Verticals>
            {
                new Verticals(){ Name = "HealthCare", Description = "One of our biggest areas of expertise in terms of Industries is Health Care domain. Our clients have chartered their course to become one of the largest managed behavioral healthcare companies in USA. The company manages mental health plan, employee assistance, and work/life programs through its nationwide third-party provider network of some 79,000 behavioral health professionals. It also provides radiology benefits management, specialty pharmaceutical management, and Medicaid management."},
                new Verticals(){ Name = "Retail", Description = "We provide feature-rich eCommerce sites which cover all key retail functions, including campaign and promotions management, catalogue management, trading analysis, multi-channel and content management system for “magazine” style content and comprehensive quality testing for your eCommerce portal, including functional and performance load testing with detailed test analysis."},
                new Verticals(){ Name = "Ecommerce", Description = "AtDrive, since its inception, has developed and deployed numerous eCommerce web development projects for its customers across the globe. Our experience helps us understand our client’s needs with respect to web development and in integrating those needs with the eCommerce services and engines available in the market today. Our team is well-versed in using different PHP frameworks such as Magento, OsCommerce, Virtuemart, Volusion and ZenCart. We can even provide you with customized eCommerce solutions over PHP, Java and .NET."},
            };   
            
        }
        #endregion

        #region  Properties

        private ObservableCollection<Verticals> _industryVerticals;
        public ObservableCollection<Verticals> IndustryVerticals
        {
            get { return _industryVerticals; }
            set
            {
                _industryVerticals = value;

                OnPropertyChanged(() => IndustryVerticals);
            }
        }
       
        #endregion

    }
}
