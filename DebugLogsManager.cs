using UnityEngine;

public static class DebugLogsManager
{
    // Check if DEBUG_LOGS is defined to allow logs
#if DEBUG_LOGS
    public static void Log(string message)
    {
        Debug.Log(message);
    }

    public static void Log(string message, UnityEngine.Object context)
    {
        Debug.Log(message, context);
    }

    public static void LogWarning(string message)
    {
        Debug.LogWarning(message);
    }

    public static void LogWarning(string message, UnityEngine.Object context)
    {
        Debug.LogWarning(message, context);
    }

    public static void LogError(string message)
    {
        Debug.LogError(message);
    }

    public static void LogError(string message, UnityEngine.Object context)
    {
        Debug.LogError(message, context);
    }
#else
    // If DEBUG_LOGS is not defined, disable logs
    public static void Log(string message) { }
    public static void LogWarning(string message) { }
    public static void LogError(string message) { }

    public static void Log(string message,UnityEngine.Object context) { }
    public static void LogWarning(string message,UnityEngine.Object context) { }
    public static void LogError(string message,UnityEngine.Object context) { }
#endif
}
