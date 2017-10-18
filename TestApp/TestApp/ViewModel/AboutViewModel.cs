using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.ViewModel
{
    public class AboutViewModel : ViewModelBase
    {
        #region Constructor
        public AboutViewModel()
        {
            About = "We at AtDrive believe there is no silver bullet when it comes to solving our clients’ technology challenges. Customized solutions are the key to success of any business, and our expertise lies in providing customized solutions based on the business needs. Our passionate commitment to research, coupled with the comprehensive market intelligence, enables us in serving a wide range of industry verticals besides making us one of the leading HR firms. We are a team of professionals possessing specific domain knowledge, who work as dynamic practice groups with trans global reach. Understanding the specific terms of code of ethics, management style, hiring practices and compensations norms, we at Get Ahead, provide specialized Technical solution services and value added services to our clients.";
            Believe = "As we kept strongly believing in the said quote and following it as the company’s spirit, AtDrive has figured its way out into being India’s leading Outsourced Product Development Partner and Technology Consulting Company with accomplished records in almost every region of Technology Development and Consulting Since its inception in the year 2013, headquartered in the Technology hub, Noida (India), AtDrive has been providing its services to the vast majority of horizons. We have always believed in stretching our wings and reaching the limits of any given technology which has always reflected as the quality of our solutions and has been insurance for the successful delivery of an unmatched client experience.We have been able to maintain a strong balance between the imagination and the real world output products for a long time now and hence the reason why our clients love us.";
            Goal = "We solve business problems by offering best possible software solutions. We have continuously proven ourselves in extreme conditions and helped our client’s business to reach full potential.We provide end to end solutions in the field of custom application development for projects of all sizes and complexities. Our expertise includes Design and Development of high-volume consumer applications, Line of Business (LOB) applications, Internal business applications, SAAS based applications, Content Management Systems, e-Commerce Application, Mobile Application, Simple to Complex Websites, Cloud Based Applications etc.";
        }
        #endregion

        #region  Properties

        private string _about;
        public string About
        {
            get { return _about; }
            set
            {
                _about = value;
                OnPropertyChanged(() => About);
            }
        }

        private string _believe;
        public string Believe
        {
            get { return _believe; }
            set
            {
                _believe = value;
                OnPropertyChanged(() => Believe);
            }
        }

        private string _goal;
        public string Goal
        {
            get { return _goal; }
            set
            {
                _goal = value;
                OnPropertyChanged(() => _goal);
            }
        }

       
        #endregion

    }
}
