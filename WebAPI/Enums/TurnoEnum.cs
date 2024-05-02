using System.Text.Json.Serialization;

namespace WebAPI.Enums;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TurnoEnum
{
    Manha,
    Tarde,
    Noite
}
