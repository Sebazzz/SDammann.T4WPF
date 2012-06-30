namespace T4WPF.PhoneTestProject {
    using System.Collections.Generic;
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

        private void anObjAppBarMenuItem_Click(object sender, System.EventArgs e) {
            this.NavigationService.Navigate(NavigationDestination.Pages.Auth.LogonPage.WithQuery(new {useFacebook=true,testFlag=1337, quickAndEasy="very true"}));
        }

        private void paramsAppBarMenuItem_Click(object sender, System.EventArgs e)
        {
            this.NavigationService.Navigate(NavigationDestination.Pages.AboutPage.WithQuery("showEpicMessage", "true",
                                                                                            "showTrialMessage", "false"));
        }

        private void queryAppBarMenuItem_Click(object sender, System.EventArgs e) {
            this.NavigationService.Navigate(NavigationDestination.MainPage.WithQuery("hasNavigatedBack=true&isExample=true"));
        }

        private void dictAppBarMenuItem_Click(object sender, System.EventArgs e) {
            this.NavigationService.Navigate(NavigationDestination.Pages.AboutPage.WithQuery(new Dictionary<string, object> {
                                                                                                                                   {"isUsingDictionary", true},
                                                                                                                                   {"verboseSyntax", "very true"}
                                                                                                                           }));
        }
    }
}