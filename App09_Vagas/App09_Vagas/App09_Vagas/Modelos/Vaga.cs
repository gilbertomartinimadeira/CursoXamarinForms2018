

using SQLite;

namespace App09_Vagas.Modelos
{
   
   [Table("vaga")]
    public class Vaga
    {
     
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public byte Quantidade { get; set; }
        public string Cidade { get; set; }       
        public double Salario { get; set; }
        public string Descricao { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
