namespace MauiAddShellItem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await AddFlyoutItems();
    }

    public async Task AddFlyoutItems()
    {
        // Get  flyout items from Web
        await Task.Delay(500);

        for (int i = 0; i < 3; i++)
        {
            var flyoutItem = new FlyoutItem
            {
                Title = $"{i}-item",
                Route = $"{i}-item"
            };

            flyoutItem.Items.Add(new ShellContent
            {
                Content = new MainPage(),
                Route = $"{i}-item"
            });

            Items.Add(flyoutItem);
        }
    }
}
