using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace T4WPF.PhoneTestProject.Pages {
    using System.Windows.Navigation;


    public partial class AboutPage : PhoneApplicationPage {
        public AboutPage() {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (e.NavigationMode == NavigationMode.New) {
                this.ContentPanel.Child = TestHelper.ConvertToGrid(this.NavigationContext.QueryString);
            }
        }
    }
}