using Dalamud.Logging;

namespace SupineSnail.StaticWrappers;

public class PluginLogWrapper : IPluginLog
{
    public void Log(string messageTemplate, params object[] values) => PluginLog.Log(messageTemplate, values);

    public void Log(Exception exception, string messageTemplate, params object[] values) => PluginLog.Log(exception, messageTemplate, values);

    public void LogVerbose(string messageTemplate, params object[] values) => PluginLog.LogVerbose(messageTemplate, values);

    public void LogVerbose(Exception exception, string messageTemplate, params object[] values) => PluginLog.LogVerbose(exception, messageTemplate, values);

    public void LogDebug(string messageTemplate, params object[] values) => PluginLog.LogDebug(messageTemplate, values);

    public void LogDebug(Exception exception, string messageTemplate, params object[] values) => PluginLog.LogDebug(exception, messageTemplate, values);

    public void LogInformation(string messageTemplate, params object[] values) => PluginLog.LogInformation(messageTemplate, values);

    public void LogInformation(Exception exception, string messageTemplate, params object[] values) => PluginLog.LogInformation(exception, messageTemplate, values);

    public void LogWarning(string messageTemplate, params object[] values) => PluginLog.LogWarning(messageTemplate, values);

    public void LogWarning(Exception exception, string messageTemplate, params object[] values) => PluginLog.LogWarning(exception, messageTemplate, values);

    public void LogError(string messageTemplate, params object[] values) => PluginLog.LogError(messageTemplate, values);

    public void LogError(Exception exception, string messageTemplate, params object[] values) => PluginLog.LogError(exception, messageTemplate, values);

    public void LogFatal(string messageTemplate, params object[] values) => PluginLog.LogFatal(messageTemplate, values);

    public void LogFatal(Exception exception, string messageTemplate, params object[] values) => PluginLog.LogFatal(exception, messageTemplate, values);

    public void Verbose(string messageTemplate, params object[] values) => PluginLog.Verbose(messageTemplate, values);

    public void Verbose(Exception exception, string messageTemplate, params object[] values) => PluginLog.Verbose(exception, messageTemplate, values);

    public void Debug(string messageTemplate, params object[] values) => PluginLog.Debug(messageTemplate, values);

    public void Debug(Exception exception, string messageTemplate, params object[] values) => PluginLog.Debug(exception, messageTemplate, values);

    public void Information(string messageTemplate, params object[] values) => PluginLog.Information(messageTemplate, values);

    public void Information(Exception exception, string messageTemplate, params object[] values) => PluginLog.Information(exception, messageTemplate, values);

    public void Warning(string messageTemplate, params object[] values) => PluginLog.Warning(messageTemplate, values);

    public void Warning(Exception exception, string messageTemplate, params object[] values) => PluginLog.Warning(exception, messageTemplate, values);

    public void Error(string messageTemplate, params object[] values) => PluginLog.Error(messageTemplate, values);

    public void Error(Exception exception, string messageTemplate, params object[] values) => PluginLog.Error(exception, messageTemplate, values);

    public void Fatal(string messageTemplate, params object[] values) => PluginLog.Fatal(messageTemplate, values);

    public void Fatal(Exception exception, string messageTemplate, params object[] values) => PluginLog.Fatal(exception, messageTemplate, values);
}