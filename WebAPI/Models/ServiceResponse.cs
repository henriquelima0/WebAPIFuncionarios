namespace WebAPI.Models;

public class ServiceResponse<T>
{
    public T? dados{ get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public bool Sucesso { get; set; } = true;
}
