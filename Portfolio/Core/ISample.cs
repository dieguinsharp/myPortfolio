using Ooui;

namespace Portfolio.Core {
    public interface ISample
    {
        string Title { get; }
        string Path { get; }
        Element CreateElement ();
        void Publish();
    }
}
