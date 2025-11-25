using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Episode09_ScrollView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowVerticalScroll(object sender, RoutedEventArgs e)
        {
            var scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                Padding = new Thickness(20)
            };

            var stackPanel = new StackPanel();
            
            var title = new TextBlock
            {
                Text = "Demo 1: Vertical Scrolling",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(title);

            var description = new TextBlock
            {
                Text = "This demonstrates vertical scrolling. The content below is longer than the available space, so a vertical scrollbar appears automatically.",
                TextWrapping = TextWrapping.Wrap,
                FontSize = 14,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(description);

            for (int i = 1; i <= 30; i++)
            {
                var border = new Border
                {
                    Background = i % 2 == 0 ? Brushes.LightGray : Brushes.White,
                    BorderBrush = Brushes.Gray,
                    BorderThickness = new Thickness(1),
                    Padding = new Thickness(15),
                    Margin = new Thickness(0, 5)
                };

                var textBlock = new TextBlock
                {
                    Text = $"Line {i}: This is a line of text to demonstrate vertical scrolling.",
                    FontSize = 14
                };

                border.Child = textBlock;
                stackPanel.Children.Add(border);
            }

            scrollViewer.Content = stackPanel;
            ContentPanel.Child = scrollViewer;
        }

        private void ShowHorizontalScroll(object sender, RoutedEventArgs e)
        {
            var mainStack = new StackPanel { Margin = new Thickness(20) };

            var title = new TextBlock
            {
                Text = "Demo 2: Horizontal Scrolling",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            mainStack.Children.Add(title);

            var description = new TextBlock
            {
                Text = "This demonstrates horizontal scrolling. The photo gallery below is wider than the available space.",
                TextWrapping = TextWrapping.Wrap,
                FontSize = 14,
                Margin = new Thickness(0, 0, 0, 20)
            };
            mainStack.Children.Add(description);

            var scrollViewer = new ScrollViewer
            {
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                VerticalScrollBarVisibility = ScrollBarVisibility.Disabled,
                Height = 220
            };

            var stackPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Margin = new Thickness(10)
            };

            string[] colors = { "#FF5733", "#FFC300", "#DAF7A6", "#33FF57", "#3357FF", "#FF33F5", "#FF8C33", "#8C33FF" };
            for (int i = 1; i <= 8; i++)
            {
                var border = new Border
                {
                    Width = 180,
                    Height = 180,
                    Background = (Brush)new BrushConverter().ConvertFrom(colors[i - 1]),
                    Margin = new Thickness(5),
                    CornerRadius = new CornerRadius(10)
                };

                var textBlock = new TextBlock
                {
                    Text = $"Photo {i}",
                    FontSize = 20,
                    Foreground = Brushes.White,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                border.Child = textBlock;
                stackPanel.Children.Add(border);
            }

            scrollViewer.Content = stackPanel;
            mainStack.Children.Add(scrollViewer);

            var scroll = new ScrollViewer { VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            scroll.Content = mainStack;
            ContentPanel.Child = scroll;
        }

        private void ShowBothDirections(object sender, RoutedEventArgs e)
        {
            var mainStack = new StackPanel { Margin = new Thickness(20) };

            var title = new TextBlock
            {
                Text = "Demo 3: Both Direction Scrolling",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            mainStack.Children.Add(title);

            var description = new TextBlock
            {
                Text = "This demonstrates scrolling in both directions. The content below is both wider and taller than the available space.",
                TextWrapping = TextWrapping.Wrap,
                FontSize = 14,
                Margin = new Thickness(0, 0, 0, 20)
            };
            mainStack.Children.Add(description);

            var scrollViewer = new ScrollViewer
            {
                Height = 400,
                Width = 600,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto
            };

            var grid = new Grid
            {
                Width = 1200,
                Height = 800,
                Background = Brushes.LightGray
            };

            var centerText = new TextBlock
            {
                Text = "Large Content Area\n1200 x 800 pixels\n\nYou can scroll both horizontally and vertically!",
                FontSize = 24,
                TextAlignment = TextAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            grid.Children.Add(centerText);

            // Add colored rectangles in corners
            var topLeft = new Border
            {
                Width = 100,
                Height = 100,
                Background = Brushes.Red,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(50)
            };
            grid.Children.Add(topLeft);

            var topRight = new Border
            {
                Width = 100,
                Height = 100,
                Background = Brushes.Blue,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(50)
            };
            grid.Children.Add(topRight);

            var bottomLeft = new Border
            {
                Width = 100,
                Height = 100,
                Background = Brushes.Green,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Bottom,
                Margin = new Thickness(50)
            };
            grid.Children.Add(bottomLeft);

            var bottomRight = new Border
            {
                Width = 100,
                Height = 100,
                Background = Brushes.Orange,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Bottom,
                Margin = new Thickness(50)
            };
            grid.Children.Add(bottomRight);

            scrollViewer.Content = grid;
            mainStack.Children.Add(scrollViewer);

            var scroll = new ScrollViewer { VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            scroll.Content = mainStack;
            ContentPanel.Child = scroll;
        }

        private void ShowLongForm(object sender, RoutedEventArgs e)
        {
            var scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto
            };

            var stackPanel = new StackPanel
            {
                Margin = new Thickness(20),
                MaxWidth = 500
            };

            var title = new TextBlock
            {
                Text = "Demo 4: Long Registration Form",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(title);

            // Personal Information Section
            var personalHeader = new TextBlock
            {
                Text = "Personal Information",
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 10, 0, 10)
            };
            stackPanel.Children.Add(personalHeader);

            AddFormField(stackPanel, "First Name:");
            AddFormField(stackPanel, "Last Name:");
            AddFormField(stackPanel, "Email:");
            AddFormField(stackPanel, "Phone:");

            // Address Section
            var addressHeader = new TextBlock
            {
                Text = "Address Information",
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 20, 0, 10)
            };
            stackPanel.Children.Add(addressHeader);

            AddFormField(stackPanel, "Street Address:");
            AddFormField(stackPanel, "City:");
            AddFormField(stackPanel, "State:");
            AddFormField(stackPanel, "Zip Code:");

            // Account Section
            var accountHeader = new TextBlock
            {
                Text = "Account Information",
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 20, 0, 10)
            };
            stackPanel.Children.Add(accountHeader);

            AddFormField(stackPanel, "Username:");
            AddFormField(stackPanel, "Password:");
            AddFormField(stackPanel, "Confirm Password:");

            // Preferences
            var prefHeader = new TextBlock
            {
                Text = "Preferences",
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 20, 0, 10)
            };
            stackPanel.Children.Add(prefHeader);

            var cb1 = new CheckBox { Content = "Receive newsletter", Margin = new Thickness(0, 5) };
            var cb2 = new CheckBox { Content = "Enable notifications", Margin = new Thickness(0, 5) };
            var cb3 = new CheckBox { Content = "Show online status", Margin = new Thickness(0, 5) };
            stackPanel.Children.Add(cb1);
            stackPanel.Children.Add(cb2);
            stackPanel.Children.Add(cb3);

            var bioLabel = new TextBlock { Text = "Bio:", Margin = new Thickness(0, 15, 0, 5) };
            var bioBox = new TextBox
            {
                Height = 100,
                TextWrapping = TextWrapping.Wrap,
                AcceptsReturn = true,
                Margin = new Thickness(0, 0, 0, 15)
            };
            stackPanel.Children.Add(bioLabel);
            stackPanel.Children.Add(bioBox);

            var submitButton = new Button
            {
                Content = "Submit",
                Width = 150,
                Height = 35,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 20, 0, 0)
            };
            stackPanel.Children.Add(submitButton);

            scrollViewer.Content = stackPanel;
            ContentPanel.Child = scrollViewer;
        }

        private void AddFormField(StackPanel parent, string label)
        {
            var labelBlock = new TextBlock { Text = label };
            var textBox = new TextBox { Margin = new Thickness(0, 5, 0, 15) };
            parent.Children.Add(labelBlock);
            parent.Children.Add(textBox);
        }

        private void ShowArticle(object sender, RoutedEventArgs e)
        {
            var scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                Padding = new Thickness(20)
            };

            var stackPanel = new StackPanel();

            var title = new TextBlock
            {
                Text = "Demo 5: Long Article",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(title);

            var subtitle = new TextBlock
            {
                Text = "Understanding WPF ScrollViewer",
                FontSize = 20,
                Foreground = Brushes.Gray,
                Margin = new Thickness(0, 0, 0, 30)
            };
            stackPanel.Children.Add(subtitle);

            string[] paragraphs = {
                "The ScrollViewer control is one of the most essential controls in WPF. It provides a scrollable area that can contain other visible elements. This is particularly useful when you have content that exceeds the available space in your application window.",
                "One of the key benefits of using ScrollViewer is its automatic behavior. When the content fits within the available space, no scrollbars are shown. However, when the content exceeds the available area, scrollbars appear automatically (when using Auto mode).",
                "ScrollViewer supports both vertical and horizontal scrolling. You can control the visibility of scrollbars independently for each direction using the VerticalScrollBarVisibility and HorizontalScrollBarVisibility properties.",
                "The control also supports touch gestures and mouse wheel scrolling out of the box. This makes it very user-friendly and intuitive for end users. They can scroll using traditional methods or modern touch interfaces.",
                "When implementing forms, articles, or any content-heavy interface, ScrollViewer should be one of your go-to controls. It ensures that all content is accessible to users regardless of their screen size or window dimensions.",
                "Performance is another important consideration. ScrollViewer is optimized for displaying large amounts of content. When combined with virtualization techniques, it can handle thousands of items efficiently.",
                "There are several properties you should be familiar with when working with ScrollViewer. These include CanContentScroll for logical vs physical scrolling, and PanningMode for touch screen support.",
                "Common mistakes include nesting ScrollViewers (which creates confusing user experiences) and wrapping controls that already have built-in scrolling capabilities like ListBox or DataGrid.",
                "Best practices suggest using Auto for ScrollBarVisibility in most cases. This provides the cleanest user interface while ensuring scrollbars appear when needed.",
                "In conclusion, ScrollViewer is a powerful and essential control in WPF. Understanding how to use it effectively will greatly improve the user experience of your applications."
            };

            foreach (var paragraph in paragraphs)
            {
                var textBlock = new TextBlock
                {
                    Text = paragraph,
                    TextWrapping = TextWrapping.Wrap,
                    FontSize = 14,
                    Margin = new Thickness(0, 0, 0, 15),
                    LineHeight = 22
                };
                stackPanel.Children.Add(textBlock);
            }

            scrollViewer.Content = stackPanel;
            ContentPanel.Child = scrollViewer;
        }

        private void ShowImageGallery(object sender, RoutedEventArgs e)
        {
            var mainStack = new StackPanel { Margin = new Thickness(20) };

            var title = new TextBlock
            {
                Text = "Demo 6: Image Gallery Grid",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            mainStack.Children.Add(title);

            var scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto
            };

            var uniformGrid = new UniformGrid
            {
                Columns = 3,
                Margin = new Thickness(10)
            };

            string[] colors = { "#FF5733", "#FFC300", "#DAF7A6", "#33FF57", "#3357FF", "#FF33F5", 
                              "#FF8C33", "#8C33FF", "#C70039", "#900C3F", "#581845", "#FFC0CB" };

            for (int i = 1; i <= 12; i++)
            {
                var border = new Border
                {
                    Background = (Brush)new BrushConverter().ConvertFrom(colors[i - 1]),
                    Margin = new Thickness(5),
                    CornerRadius = new CornerRadius(10),
                    Height = 200
                };

                var textBlock = new TextBlock
                {
                    Text = $"Photo {i}",
                    FontSize = 24,
                    Foreground = Brushes.White,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                border.Child = textBlock;
                uniformGrid.Children.Add(border);
            }

            scrollViewer.Content = uniformGrid;
            mainStack.Children.Add(scrollViewer);

            ContentPanel.Child = mainStack;
        }

        private void ShowSettings(object sender, RoutedEventArgs e)
        {
            var scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto
            };

            var stackPanel = new StackPanel { Margin = new Thickness(20) };

            var title = new TextBlock
            {
                Text = "Demo 7: Settings Panel",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(title);

            // General Settings
            var generalGroup = CreateGroupBox("General Settings");
            var generalStack = new StackPanel { Margin = new Thickness(10) };
            generalStack.Children.Add(new CheckBox { Content = "Start with Windows", Margin = new Thickness(0, 5) });
            generalStack.Children.Add(new CheckBox { Content = "Minimize to system tray", Margin = new Thickness(0, 5) });
            generalStack.Children.Add(new CheckBox { Content = "Check for updates", Margin = new Thickness(0, 5) });
            generalGroup.Content = generalStack;
            stackPanel.Children.Add(generalGroup);

            // Display Settings
            var displayGroup = CreateGroupBox("Display Settings");
            var displayStack = new StackPanel { Margin = new Thickness(10) };
            displayStack.Children.Add(new TextBlock { Text = "Font Size:", Margin = new Thickness(0, 5) });
            displayStack.Children.Add(new Slider { Minimum = 10, Maximum = 24, Value = 14, Margin = new Thickness(0, 0, 0, 10) });
            displayStack.Children.Add(new TextBlock { Text = "Zoom Level:", Margin = new Thickness(0, 5) });
            displayStack.Children.Add(new Slider { Minimum = 50, Maximum = 200, Value = 100 });
            displayGroup.Content = displayStack;
            stackPanel.Children.Add(displayGroup);

            // Privacy Settings
            var privacyGroup = CreateGroupBox("Privacy Settings");
            var privacyStack = new StackPanel { Margin = new Thickness(10) };
            privacyStack.Children.Add(new CheckBox { Content = "Send anonymous usage data", Margin = new Thickness(0, 5) });
            privacyStack.Children.Add(new CheckBox { Content = "Allow crash reporting", Margin = new Thickness(0, 5) });
            privacyStack.Children.Add(new CheckBox { Content = "Remember recent files", Margin = new Thickness(0, 5) });
            privacyGroup.Content = privacyStack;
            stackPanel.Children.Add(privacyGroup);

            // Advanced Settings
            var advancedGroup = CreateGroupBox("Advanced Settings");
            var advancedStack = new StackPanel { Margin = new Thickness(10) };
            advancedStack.Children.Add(new CheckBox { Content = "Enable experimental features", Margin = new Thickness(0, 5) });
            advancedStack.Children.Add(new CheckBox { Content = "Hardware acceleration", Margin = new Thickness(0, 5) });
            advancedStack.Children.Add(new CheckBox { Content = "Debug mode", Margin = new Thickness(0, 5) });
            advancedGroup.Content = advancedStack;
            stackPanel.Children.Add(advancedGroup);

            scrollViewer.Content = stackPanel;
            ContentPanel.Child = scrollViewer;
        }

        private GroupBox CreateGroupBox(string header)
        {
            return new GroupBox
            {
                Header = header,
                Margin = new Thickness(0, 10)
            };
        }

        private void ShowVisibilityModes(object sender, RoutedEventArgs e)
        {
            var mainScroll = new ScrollViewer { VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            var stackPanel = new StackPanel { Margin = new Thickness(20) };

            var title = new TextBlock
            {
                Text = "Demo 8: ScrollBar Visibility Modes",
                FontSize = 28,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 20)
            };
            stackPanel.Children.Add(title);

            var grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            // Auto Mode
            var autoStack = new StackPanel { Margin = new Thickness(5) };
            Grid.SetColumn(autoStack, 0);
            autoStack.Children.Add(new TextBlock { Text = "Auto Mode", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 5) });
            var autoScroll = new ScrollViewer
            {
                Height = 150,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1)
            };
            var autoContent = new StackPanel();
            for (int i = 1; i <= 10; i++)
            {
                autoContent.Children.Add(new TextBlock { Text = $"Line {i}", Margin = new Thickness(5) });
            }
            autoScroll.Content = autoContent;
            autoStack.Children.Add(autoScroll);
            autoStack.Children.Add(new TextBlock
            {
                Text = "Shows scrollbar only when needed",
                FontSize = 11,
                Foreground = Brushes.Gray,
                Margin = new Thickness(0, 5, 0, 0),
                TextWrapping = TextWrapping.Wrap
            });
            grid.Children.Add(autoStack);

            // Visible Mode
            var visibleStack = new StackPanel { Margin = new Thickness(5) };
            Grid.SetColumn(visibleStack, 1);
            visibleStack.Children.Add(new TextBlock { Text = "Visible Mode", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 5) });
            var visibleScroll = new ScrollViewer
            {
                Height = 150,
                VerticalScrollBarVisibility = ScrollBarVisibility.Visible,
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1)
            };
            var visibleContent = new StackPanel();
            for (int i = 1; i <= 3; i++)
            {
                visibleContent.Children.Add(new TextBlock { Text = $"Line {i}", Margin = new Thickness(5) });
            }
            visibleScroll.Content = visibleContent;
            visibleStack.Children.Add(visibleScroll);
            visibleStack.Children.Add(new TextBlock
            {
                Text = "Always shows scrollbar (even when not needed)",
                FontSize = 11,
                Foreground = Brushes.Gray,
                Margin = new Thickness(0, 5, 0, 0),
                TextWrapping = TextWrapping.Wrap
            });
            grid.Children.Add(visibleStack);

            stackPanel.Children.Add(grid);

            var grid2 = new Grid { Margin = new Thickness(0, 20, 0, 0) };
            grid2.ColumnDefinitions.Add(new ColumnDefinition());
            grid2.ColumnDefinitions.Add(new ColumnDefinition());

            // Hidden Mode
            var hiddenStack = new StackPanel { Margin = new Thickness(5) };
            Grid.SetColumn(hiddenStack, 0);
            hiddenStack.Children.Add(new TextBlock { Text = "Hidden Mode", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 5) });
            var hiddenScroll = new ScrollViewer
            {
                Height = 150,
                VerticalScrollBarVisibility = ScrollBarVisibility.Hidden,
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1)
            };
            var hiddenContent = new StackPanel();
            for (int i = 1; i <= 15; i++)
            {
                hiddenContent.Children.Add(new TextBlock { Text = $"Line {i}", Margin = new Thickness(5) });
            }
            hiddenScroll.Content = hiddenContent;
            hiddenStack.Children.Add(hiddenScroll);
            hiddenStack.Children.Add(new TextBlock
            {
                Text = "No scrollbar, but can still scroll with mouse wheel",
                FontSize = 11,
                Foreground = Brushes.Gray,
                Margin = new Thickness(0, 5, 0, 0),
                TextWrapping = TextWrapping.Wrap
            });
            grid2.Children.Add(hiddenStack);

            // Disabled Mode
            var disabledStack = new StackPanel { Margin = new Thickness(5) };
            Grid.SetColumn(disabledStack, 1);
            disabledStack.Children.Add(new TextBlock { Text = "Disabled Mode", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 5) });
            var disabledScroll = new ScrollViewer
            {
                Height = 150,
                VerticalScrollBarVisibility = ScrollBarVisibility.Disabled,
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1)
            };
            var disabledContent = new StackPanel();
            for (int i = 1; i <= 15; i++)
            {
                disabledContent.Children.Add(new TextBlock { Text = $"Line {i}", Margin = new Thickness(5) });
            }
            disabledScroll.Content = disabledContent;
            disabledStack.Children.Add(disabledScroll);
            disabledStack.Children.Add(new TextBlock
            {
                Text = "No scrolling at all - content is clipped",
                FontSize = 11,
                Foreground = Brushes.Gray,
                Margin = new Thickness(0, 5, 0, 0),
                TextWrapping = TextWrapping.Wrap
            });
            grid2.Children.Add(disabledStack);

            stackPanel.Children.Add(grid2);

            mainScroll.Content = stackPanel;
            ContentPanel.Child = mainScroll;
        }
    }
}
