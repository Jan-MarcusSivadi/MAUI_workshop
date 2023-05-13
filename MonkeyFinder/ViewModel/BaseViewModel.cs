namespace MonkeyFinder.ViewModel;
public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {
        
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotRefreshing))]
    bool isRefreshing;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !isBusy;
    public bool IsNotRefreshing => !isRefreshing;
}
