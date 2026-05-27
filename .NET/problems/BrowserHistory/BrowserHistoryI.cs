namespace BrowserHistory.App;

public class BrowserHistoryI
{
    private BrowserPage _head;
    private BrowserPage _tail;
    private BrowserPage _current;

    public BrowserHistoryI(string homepage)
    {
        _current = new BrowserPage(homepage);
        _head = _current;
        _tail = _current;
    }

    public void Visit(string url)
    {
        //The current page Next pointer points to the new page
        _current.Next = new BrowserPage(url);
        //The new page Prev pointer points to the current page
        _current.Next.Prev = _current;
        //The current page becomes the new page
        _current = _current.Next;
        //The new page becomes the tail of the list
        _tail = _current;
        //The Next pointer of the current page is null because there are no more pages after it
        _current.Next = null;
    }

    public string Back(int steps)
    {
        BrowserPage curr = _current;

        for (int x = steps; x > 0; x--)
        {
            if (curr.Prev == null)
                break;

            curr = curr.Prev;
        }
        _current = curr;
        return curr.Url;
    }

    public string Forward(int steps)
    {
        BrowserPage curr = _current;

        for (int x = steps; x > 0; x--)
        {
            if (curr.Next == null)
                break;

            curr = curr.Next;
        }

        _current = curr;
        return curr.Url;
    }
}