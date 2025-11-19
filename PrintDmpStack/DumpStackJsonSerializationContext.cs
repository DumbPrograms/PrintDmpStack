using System.Text.Json.Serialization;

namespace PrintDmpStack;

[JsonSerializable(typeof(DumpStackFrame[]))]
public partial class DumpStackJsonSerializationContext : JsonSerializerContext
{
}
