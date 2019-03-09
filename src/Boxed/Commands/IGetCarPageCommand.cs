namespace Boxed.Commands
{
    using Boxed.ViewModels;
    using Boxed.AspNetCore;

    public interface IGetCarPageCommand : IAsyncCommand<PageOptions>
    {
    }
}
