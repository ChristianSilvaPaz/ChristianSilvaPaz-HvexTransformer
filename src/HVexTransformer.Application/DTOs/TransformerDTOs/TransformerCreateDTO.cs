namespace HVexTransformer.Application.DTOs.TransformerDTOs;

public class TransformerCreateDTO
{
    public string IdUser { get; private set; }
    public string Name { get; set; }
    public int InternalNumber { get; private set; }
    public int TensionClass { get; private set; }
    public int Potency { get; private set; }
    public int Current { get; private set; }
}
