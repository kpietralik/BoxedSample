namespace Boxed.Commands
{
    using Boxed.ViewModels;
    using Boxed.AspNetCore;

    public interface IPutCarCommand : IAsyncCommand<int, SaveCar>
    {
    }
}
