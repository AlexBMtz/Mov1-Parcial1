using Parcial1.Models;

namespace Parcial1.Pages;

public partial class NewsPage : ContentPage
{
    private List<NewsModel> _news = [new() { Title = "Se abre curso de automatización", Summary="El maestro xxx impartirá el nuevo curso de automatización el próximo mes", FullContent="Noticia completa"},

    new() { Title = "Actualización en deportes!", Summary="Este es un resumen de la noticia", FullContent="Noticia completa"}];
    public NewsPage()
    {
        InitializeComponent();
        newsListView.ItemsSource = _news;
    }
}