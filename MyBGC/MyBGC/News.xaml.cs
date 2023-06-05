namespace MyBGC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class News : ContentPage
    {
        public News()
        {
            InitializeComponent();
            RSSNews();
        }

        async void RSSNews()
        {
            try
            {
                var feed = await FeedReader.ReadAsync("https://rss.app/feeds/02bfsW31UPrZPeSh.xml");

                foreach (FeedItem item in feed.Items)
                {
                    StackLayout back = new StackLayout
                        { BackgroundColor = Color.CornflowerBlue, Margin = new Thickness(15, 15, 15, 5) };

                    Grid grid = new Grid
                    {
                        RowDefinitions =
                        {
                            new RowDefinition { Height = GridLength.Auto }, //image
                            new RowDefinition { Height = GridLength.Auto }, //title
                            new RowDefinition { Height = GridLength.Auto }, //body
                        }
                    };
                    grid.Margin = 10;
                    int StartImgSrc = item.Description.IndexOf("img src=") + 9;
                    int EndImgSrc = item.Description.IndexOf("\u0022", StartImgSrc + 1);
                    string SourceImg = item.Description.Substring(StartImgSrc, EndImgSrc - StartImgSrc);
                    grid.Children.Add(new Image
                    {
                        Source = SourceImg,
                        Aspect = Aspect.AspectFit,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HeightRequest = 200
                    }, 0, 0);

                    int StartDesc = item.Description.IndexOf("<div>", EndImgSrc) + 5;
                    int EndDesc = item.Description.IndexOf("</div>");
                    string Desc = item.Description.Substring(StartDesc, EndDesc - StartDesc);

                    Label DescLabel = new Label { };
                    var z = new FormattedString();
                    z.Spans.Add(new Span { Text = Desc });

                    grid.Children.Add(
                        new Label
                        {
                            Text = item.Title, BackgroundColor = Color.FromHex("daedf4"), Padding = 5,
                            TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Bold
                        }, 0, 1);

                    string dots = Desc.Substring(Desc.Length - 4, 4);

                    if (dots == "....")
                    {
                        var span = new Span
                        {
                            Text = "(Читать далее на сайте БГК)", TextColor = Color.Blue,
                            TextDecorations = TextDecorations.Underline
                        };
                        span.GestureRecognizers.Add(new TapGestureRecognizer
                        {
                            Command = new Command(async () =>
                                await Browser.OpenAsync(new Uri(item.Link), BrowserLaunchMode.SystemPreferred))
                        });
                        z.Spans.Add(span);
                    }

                    grid.Children.Add(
                        new Label
                        {
                            FormattedText = z, BackgroundColor = Color.FromHex("daedf4"), Padding = 5,
                            TextColor = Color.Black
                        }, 0, 2);


                    back.Children.Add(grid);
                    back.Children.Add(new Label
                    {
                        Text = $"{item.PublishingDate:D}", Margin = new Thickness(0, 0, 15, 15),
                        HorizontalTextAlignment = TextAlignment.End, TextColor = Color.Black
                    });
                    NewsFeed.Children.Add(back);
                }
            }
            catch (Exception ex)
            {
                NewsFeed.Children.Add(new Label{Text = "Отсутствует подключение к интернету", VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand, HorizontalTextAlignment = TextAlignment.Center}); 
            }
                
        }
    }
}