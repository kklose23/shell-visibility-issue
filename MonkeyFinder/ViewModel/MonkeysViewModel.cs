using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  private AppShellViewModel _appShell;

  public MonkeysViewModel(AppShellViewModel appShell)
  {
    _appShell = appShell;
  }

  [RelayCommand]
  async Task GoToDetails(Monkey monkey)
  {
    _appShell.Visible = !_appShell.Visible;
  }
}
