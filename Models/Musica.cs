using System;

namespace API.Models
{
    public class Musica
    {
        //Construtor
        public Musica() => CriadoEm = DateTime.Now;

        //Atributos ou propriedades
        public int id { get; set; }
        public string nome { get; set; }
        public int anoLancamento { get; set; }
        public string cantor { get; set; }
        public string estilo { get; set; }
        public DateTime CriadoEm { get; set; }


        //ToString
        public override string ToString() =>
            $"Nome: {nome} | cantor: {cantor} | Criado em: {CriadoEm}";
    }
}