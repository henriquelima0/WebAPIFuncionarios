using System.Text.Json.Serialization;

namespace WebAPI.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DepartamentoEnum
{
    RH,
    Financeiro,
    Compras,
    Atendimento,
    Zeladoria,
    TI
}
