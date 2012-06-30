namespace T4WPF.PhoneTestProject {
    using System.Windows.Navigation;
    using Microsoft.Phone.Controls;


    public partial class MainPage : PhoneApplicationPage {
        // Constructor
        public MainPage() {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo (NavigationEventArgs e) {
            if (e.NavigationMode == NavigationMode.New) {
                this.ContentPanel.Child = TestHelper.ConvertToGrid(this.NavigationContext.QueryString);
            }
        }
    }
}