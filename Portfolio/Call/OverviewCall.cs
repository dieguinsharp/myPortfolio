using Ooui;
using Portfolio.Core;
using Portfolio.Views;
using Xamarin.Forms;

namespace Portfolio.Call {
    public class OverviewCall : ISample{
        public string Title => "Overview";
        public string Path => "/overview";

        public Ooui.Element CreateElement()
        {
            var page = new Overview();
            return page.GetOouiElement();
        }

        public void Publish()
        {
            UI.Publish(Path, CreateElement);
        }
    }
}
