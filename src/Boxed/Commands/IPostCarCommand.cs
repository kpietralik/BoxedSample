namespace Boxed.Commands
{
    using Boxed.ViewModels;
    using Boxed.AspNetCore;

    public interface IPostCarCommand : IAsyncCommand<SaveCar>
    {
    }
}
