using System.Windows.Input;

namespace AdaptiveCollectionView
{
    public partial class MainPage : ContentPage
    {
        public List<string> SimpleList { get; set; }

        public ICommand ItemSelectedCommand { get; private set; }
        public MainPage()
        {
            InitializeComponent();

            SimpleList = new List<string> { "item 1", "item 2", "item 3" };

            ItemSelectedCommand = new Command<string>(ItemSelected);

            BindingContext = this;

        }

        private async void ItemSelected(string selectedItem)
        {
            await Navigation.PushAsync(new Page1());
        }
    }

}
