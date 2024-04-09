using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AdaptiveCollectionView;

public partial class AdaptiveSampleView : ContentView
{

    public static readonly BindableProperty CollectionItemsProperty =
    BindableProperty.Create(
        nameof(CollectionItems),
        typeof(List<string>),
        typeof(AdaptiveSampleView),
        null,
        BindingMode.OneWay);


    public static readonly BindableProperty NavigateCommandProperty =
    BindableProperty.Create(
        nameof(NavigateCommand),
        typeof(ICommand),
        typeof(AdaptiveSampleView),
        null,
        BindingMode.OneWay);

    public AdaptiveSampleView()
	{
		InitializeComponent();
    }

    public List<string> CollectionItems
    {
        get => (List<string>)GetValue(CollectionItemsProperty);
        set => SetValue(CollectionItemsProperty, value);
    }

    public ICommand NavigateCommand
    {
        get => (ICommand)GetValue(NavigateCommandProperty);
        set => SetValue(NavigateCommandProperty, value);
    }
}