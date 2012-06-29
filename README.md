SDammann.T4WPF
==============

Strongly-typed navigation page link generator T4-file for WPF, Silverlight, Windows Phone and WinRT. 

The file generates strongly-typed helpers for page navigation via [NavigationService](http://msdn.microsoft.com/en-us/library/system.windows.navigation.navigationservice.aspx) in WPF, Silverlight, Windows Phone and WinRT. It is inspired by the [T4MVC](http://t4mvc.codeplex.com/) project.

The advantage of the strongly-typed helpers are primarily compile time safety. It eleminates the use of string literals by dynamically generating the navigation objects. If you use this component, and move a Page in the project, you no longer discover all the navigation errors by running the application, but already at compile time.

## Features
The current features include:
- Strongly-typed documented helpers
- Supports nested pages in directories
- Helper object with methods to add navigation arguments

## Usage
First, make sure the text template is added to your project: Download the [NuGet Package](https://nuget.org/packages/SDammann.T4WPF) or download the T4 template manually and add it.

Then, in any call to `NavigationService.Navigate` method, you can use one of the members of the `NavigationDestination` generated class or its subclasses as parameter. Its that simple! :)

Let's say we have a 'SettingsPage.xaml' in the 'Pages' folder. We can navigate to this page via this way:
    this.NavigationService.Navigate(NavigationDestination.Pages.SettingsPage);

Let's say we have a 'RegistrationPage.xaml' in the 'Pages/Auth' folder. We want to pass two parameters: 
- 'useFacebook' with value 'true' and
- 'username' with value 'Sebazzz'

We can navigate to this page via these three ways:

    this.NavigationService.NavigateTo(
        NavigationDestination.Pages.Auth.RegistrationPage.WithQuery(
            new Dictionary<string, object> {
                                                    {"useFacebook", true},
                                                    {"username", "Sebazzz"}
                                            }
        ));

    this.NavigationService.NavigateTo(
        NavigationDestination.Pages.Auth.RegistrationPage.WithQuery(
            "useFacebook", true,
            "username", "Sebazzz"));

    this.NavigationService.NavigateTo(
        NavigationDestination.Pages.Auth.RegistrationPage.WithQuery("useFacebook=true&username=Sebazzz"));
	
All ways are equivalent.
	
## Wish-list
The current unimplemented wish-list. Most of these items matter in most of the projects:
- Check if Page is really a Page via interop
- Also handle files linked into the project

## Contributors
Contributions to this project are welcome! Contact me via my Github profile!