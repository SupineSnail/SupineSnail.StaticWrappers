namespace SupineSnail.StaticWrappers;

/// <summary>
/// Class wrapping Dalamud static <seealso cref="Dalamud.PluginLog"/> functions for unit testability
/// </summary>
public interface IPluginLog
{
    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Log(string, object[])"/>
    void Log(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Log(Exception, string, object[])"/>
    void Log(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogVerbose(string, object[])"/>
    void LogVerbose(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogVerbose(Exception, string, object[])"/>
    void LogVerbose(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogDebug(string, object[])"/>
    void LogDebug(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogDebug(Exception, string, object[])"/>
    void LogDebug(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogInformation(string, object[])"/>
    void LogInformation(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogInformation(Exception, string, object[])"/>
    void LogInformation(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogWarning(string, object[])"/>
    void LogWarning(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogWarning(Exception, string, object[])"/>
    void LogWarning(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogError(string, object[])"/>
    void LogError(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogError(Exception, string, object[])"/>
    void LogError(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogFatal(string, object[])"/>
    void LogFatal(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.LogFatal(Exception, string, object[])"/>
    void LogFatal(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Verbose(string, object[])"/>
    void Verbose(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Verbose(Exception, string, object[])"/>
    void Verbose(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Debug(string, object[])"/>
    void Debug(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Debug(Exception, string, object[])"/>
    void Debug(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Information(string, object[])"/>
    void Information(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Information(Exception, string, object[])"/>
    void Information(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Warning(string, object[])"/>
    void Warning(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Warning(Exception, string, object[])"/>
    void Warning(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Error(string, object[])"/>
    void Error(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Error(Exception, string, object[])"/>
    void Error(Exception exception, string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Fatal(string, object[])"/>
    void Fatal(string messageTemplate, params object[] values);

    /// <inheritdoc cref="Dalamud.Logging.PluginLog.Fatal(Exception, string, object[])"/>
    void Fatal(Exception exception, string messageTemplate, params object[] values);
}