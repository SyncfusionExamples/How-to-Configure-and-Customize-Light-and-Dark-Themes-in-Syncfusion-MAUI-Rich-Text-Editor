using Syncfusion.Maui.Inputs;
using Syncfusion.Maui.Themes;

namespace RTEThemeCustomizationSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RichTextEditor.Text = @"<p><strong>Hello Frank,</strong></p><p>I hope you're doing well. I'm writing to follow up on our recent conversation regarding <strong>MAUI controls development</strong>.</p><p>Here’s a quick summary of the key points:</p><ul><li>✅ Kickoff scheduled for <em>August 19</em></li><li>📌 Deliverables due by <em>September 30</em></li><li>💬 Weekly sync every <em>Tuesday</em> at <em>10:00 AM (UTC+05:30)</em></li></ul><p>If you need more details, feel free to reach out. You can also refer to our <a href='https://help.syncfusion.com/maui/release-notes'>release notes page</a> for updates.</p><p>Best regards,<br/><strong>Ivy</strong><br/>Technical Project Coordinator</p>";
        }

        private void OnTextColorChanged(object sender, ColorChangedEventArgs e)
        {
            RichTextEditor.ToolbarSettings.TextColor = e.NewColor;
        }

        private void OnToolbarBackgroundColorChanged(object sender, ColorChangedEventArgs e)
        {
            RichTextEditor.ToolbarSettings.BackgroundColor = e.NewColor;
        }

        private void OnSelectionHighlightColorChanged(object sender, ColorChangedEventArgs e)
        {
            RichTextEditor.ToolbarSettings.SelectionColor = e.NewColor;
        }

        private void OnThemeSwitchToggled(object sender, ToggledEventArgs e)
        {
            var app = Application.Current;
            if (app == null || app.Resources == null || app.Resources.MergedDictionaries == null)
                return;

            var mergedDictionaries = app.Resources.MergedDictionaries;

            var theme = mergedDictionaries
                .OfType<SyncfusionThemeResourceDictionary>()
                .FirstOrDefault();

            if (theme == null)
                return;

            if (e.Value)
            {
                // Dark theme
                theme.VisualTheme = SfVisuals.MaterialDark;
                app.UserAppTheme = AppTheme.Dark;
                ThemeLabel.Text = "Dark";
            }
            else
            {
                // Light theme (default)
                theme.VisualTheme = SfVisuals.MaterialLight;
                app.UserAppTheme = AppTheme.Light;
                ThemeLabel.Text = "Light";
            }
        }

    }
}
