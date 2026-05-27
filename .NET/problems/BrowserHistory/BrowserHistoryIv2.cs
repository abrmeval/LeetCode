namespace BrowserHistory.App;

public class BrowserHistoryIv2
{
	private List<string> _history;
	private int _currIndex = -1;

    public BrowserHistoryIv2(string homepage)
    {
        // _history = new List<string>(){homepage};
		// _history = new() {homepage};
		_history = [homepage];
		_currIndex = 0;
    }

    public void Visit(string url)
    {
        int last = _currIndex + 1;
		_history = _history[0..last];		
		_history.Add(url);
		_currIndex++;
    }

    public string Back(int steps)
    {
		_currIndex = _currIndex - steps;
		
		if(_currIndex < 0)
			_currIndex = 0;
		
        return _history[_currIndex];
    }

    public string Forward(int steps)
    {
		_currIndex = _currIndex + steps;
		
		if(_currIndex >= _history.Count)
			_currIndex = _history.Count - 1;
		
        return _history[_currIndex];
    }
}