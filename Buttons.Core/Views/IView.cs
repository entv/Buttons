namespace Buttons.Core.Views
{
    public interface IView
    {
        public string Text { set; }
        public delegate void QueryHandler(string query);
        public event QueryHandler OnButtonClick;
    }
}
