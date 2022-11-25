using HVexTransformer.Domain.Entities;

namespace HVexTransformer.Application.DTOs.TransformerDTOs;

public class TransformerResponseDTO
{
    public string Id { get; set; }
    public string IdUser { get; set; }
    public string Name { get; set; }
    public int InternalNumber { get; set; }
    public int TensionClass { get; set; }
    public int Potency { get; set; }
    public int Current { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public List<Test> Tests { get; set; }
}
