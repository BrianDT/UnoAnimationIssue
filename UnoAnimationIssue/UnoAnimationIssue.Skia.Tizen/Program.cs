using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoAnimationIssue.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoAnimationIssue.App(), args);
            host.Run();
        }
    }
}
