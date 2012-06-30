namespace T4WPF.PhoneTestProject {
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;


    public static class TestHelper {
        public static UIElement ConvertToGrid (IDictionary<string, string> navigationArguments) {
            if (navigationArguments == null || navigationArguments.Count == 0) {
                TextBlock noQueryString = new TextBlock();
                noQueryString.Text = "No query string";
                return noQueryString;
            }

            Grid g = new Grid();
            g.ColumnDefinitions.Add(new ColumnDefinition());
            g.ColumnDefinitions.Add(new ColumnDefinition());

            g.RowDefinitions.Add(new RowDefinition());

            // header
            TextBlock c1Header = new TextBlock();
            c1Header.Text = "name";
            g.Children.Add(c1Header);
            Grid.SetColumn(c1Header, 0);
            Grid.SetRow(c1Header, 0);

            TextBlock c2Header = new TextBlock();
            c2Header.Text = "value";
            g.Children.Add(c2Header);
            Grid.SetColumn(c2Header, 1);
            Grid.SetRow(c2Header, 0);

            // enumerate and add
            int i = 1;
            foreach (KeyValuePair<string, string> pair in navigationArguments) {
                g.RowDefinitions.Add(new RowDefinition());

                TextBlock c1 = new TextBlock();
                c1.Text = pair.Key;
                g.Children.Add(c1);
                Grid.SetColumn(c1, 0);
                Grid.SetRow(c1, i);

                TextBlock c2 = new TextBlock();
                c2.Text = pair.Value;
                g.Children.Add(c2);
                Grid.SetColumn(c2, 1);
                Grid.SetRow(c2, i);

                i++;
            }

            return g;
        }
    }
}