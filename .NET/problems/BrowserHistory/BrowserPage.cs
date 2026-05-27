namespace BrowserHistory.App;

public class BrowserPage {
    public string Url;
    public BrowserPage Prev;
    public BrowserPage Next;

    public BrowserPage(string url) {
        this.Url = url;
        this.Prev = null;
        this.Next = null;
    }
}