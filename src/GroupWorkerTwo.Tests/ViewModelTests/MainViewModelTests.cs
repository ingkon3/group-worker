using GroupWorkerTwo.UI.ViewModels;

namespace GroupWorkerTwo.Tests.ViewModelTests;

public class MainViewModelTests
{
    [Fact]
    public void Test()
    {
        var viewModel = new MainWindowViewModel();
        Assert.NotNull(viewModel);
    }
}
