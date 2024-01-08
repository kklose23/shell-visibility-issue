namespace MonkeyFinder.ViewModel;

public partial class AppShellViewModel : ObservableObject
{  
  public AppShellViewModel()
  {
  }

  [ObservableProperty]
  bool _visible = true;
}
