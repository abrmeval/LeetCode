using BrowserHistory.App;
Console.WriteLine("Hello, World!");

BrowserHistoryIv3 browserHistory = new BrowserHistoryIv3("neetcode.com");
browserHistory.Visit("google.com");       // You are in "neetcode.com". Visit "google.com"
browserHistory.Visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
browserHistory.Visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
browserHistory.Back(1);                   // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
browserHistory.Back(1);                   // You are in "facebook.com", move back to "google.com" return "google.com"
browserHistory.Forward(1);                // You are in "google.com", move forward to "facebook.com" return "facebook.com"
browserHistory.Visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
browserHistory.Forward(2);                // You are in "linkedin.com", you cannot move forward any steps.
browserHistory.Back(2);                   // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
browserHistory.Back(7);                   // You are in "google.com", you can move back only one step to "neetcode.com". return "neetcode.com"