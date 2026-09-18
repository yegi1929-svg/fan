namespace FanchantPractice.App.Views;
internal static class PagePlaceholder
{
    public static View Create(string title, string description) => new VerticalStackLayout { Padding = new Thickness(20, 40), Spacing = 12, Children = { new Label { Text = title, FontSize = 24, FontAttributes = FontAttributes.Bold }, new Label { Text = description, FontSize = 16, TextColor = Color.FromArgb("#B9B9C0") } } };
}
