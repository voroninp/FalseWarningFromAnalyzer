using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace FalseWarningFromAnalyzer;

public static partial class LoggerExtensions
{
    [LoggerMessage(
            Level = LogLevel.Warning,
            Message = "We are using custom SQL. This is not stable against migrations. Method: {Method} Explanation: {Explanation}")]
    public static partial void WarnCustomSqlIsUsed(this ILogger logger, string explanation, [CallerMemberName] string? method = null);
}
