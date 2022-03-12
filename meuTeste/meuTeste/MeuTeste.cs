using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

public class MeuTeste
{
    [BsonId()]
    public ObjectId Id { get; set; }
    [Required]
    [Display(Name = "Nome")]
    [BsonRequired()]
    [BsonElement("Nome")]
    public string Nome { get; set; }
    [Required]
    [Display(Name = "Cargo")]
    [BsonElement("Cargo")]
    [BsonRequired()]
    public string Cargo { get; set; }
}
