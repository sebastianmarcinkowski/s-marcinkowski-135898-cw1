namespace s_marcinkowski_135898_cw1;

public class Logger
{
    private static readonly Logger _instance = new Logger();
    private List<string> _logMessages;
    
    public static Logger Instance
    {
        get { return _instance; }
    }
    
    private Logger()
    {
        _logMessages = new List<string>();
    }
    
    public void Log(string message)
    {
        _logMessages.Add($"{DateTime.Now}: {message}");
    }
    
    public IEnumerable<string> GetLogMessages()
    {
        return _logMessages.AsReadOnly();
    }
}