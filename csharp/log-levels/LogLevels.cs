static class LogLine {
    /// <summary>
    /// Returns the message from a log line
    /// </summary>
    /// <param name="logLine"></param>
    /// <returns></returns>
    public static string Message(string logLine) {
        return logLine.Split(':')[1].Trim();
    }

    /// <summary>
    /// Returns the log level from a log line
    /// </summary>
    /// <param name="logLine"></param>
    /// <returns></returns>
    public static string LogLevel(string logLine) {
        return logLine.Split(':')[0].Trim('[').Trim(']').ToLower();
    }

    /// <summary>
    /// Returns the reformatted log line
    /// </summary>
    /// <param name="logLine"></param>
    /// <returns></returns>
    public static string Reformat(string logLine) {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
