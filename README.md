SDammann.T4WPF
==============

Strongly-typed navigation page generator T4-file. The file generates strongly-typed helpers for page navigation via [NavigationService](http://msdn.microsoft.com/en-us/library/system.windows.navigation.navigationservice.aspx) in WPF, Silverlight, Windows Phone and WinRT. The advantage of the strongly-typed helpers are primarily compile time safety. It eleminates the use of string literals by dynamically generating the navigation objects. If you use this component, and move a Page in the project, you no longer discover all the navigation errors by running the application, but already at compile time.

The current features include:
- Strongly-typed documented helpers
- Supports nested pages in directories
- Helper object with methods to add navigation arguments

The current unimplemented wish-list. Most of these items matter in most of the projects:
- Check if Page is really a Page via interop
- Also handle files linked into the project

## Contributors
Contributions to this project are welcome! Contact me via my Github profile!