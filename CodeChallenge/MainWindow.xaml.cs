using CodeChallange.Primitives;
using CodeChallenge.DataReader.Services;
using CodeChallenge.GraphicRenderer;
using System.Windows;
namespace CodeChallenge
{
    public partial class MainWindow : Window
    {
        private readonly Renderer _renderer;
        private readonly List<BasePrimitive>? _primitives;
        public MainWindow()
        {
            InitializeComponent();

            var reader = new JsonDataReader();

            _primitives = reader.ReadData("test.json");

            _renderer = new Renderer();
            _renderer.Render(_primitives, graphicCanvas);
        }

        private void ZoomIn_Click(object sender, RoutedEventArgs e)
        {
            _renderer.ZoomIn();
            Render();
        }

        private void ZoomOut_Click(object sender, RoutedEventArgs e)
        {
            _renderer.ZoomOut();
            Render();
        }

        private void Render()
        {
            graphicCanvas.Children.Clear();
            _renderer.Render(_primitives, graphicCanvas);
        }
    }
}