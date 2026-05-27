public class BrowserHistoryIv3 {

	private List<string> _history;
	private int _currIndex = -1;
    private int _count = 0; 

    public BrowserHistoryIv3(string homepage) {       
		_history = [homepage];
		_currIndex = 0;
        _count = 1;
    }
    
    public void Visit(string url) {
         _count = _currIndex + 1;

         if(_count == _history.Count) 
            _history.Add(url);
        else 
            _history[_count] = url;
            
		_currIndex++;
        _count++;
    }
    
    public string Back(int steps) {
        _currIndex = _currIndex - steps;
		
		if(_currIndex < 0)
			_currIndex = 0;
		
        return _history[_currIndex];
    }
    
    public string Forward(int steps) {
        _currIndex = _currIndex + steps;
		
		if(_currIndex >= _count)
			_currIndex = _count - 1;
		
        return _history[_currIndex];
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */