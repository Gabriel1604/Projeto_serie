using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        private bool Favorito { get; set; }

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Favorito = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "G�nero: " + this.Genero + Environment.NewLine;
            retorno += "T�tulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descri��o: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de In�cio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;
            retorno += "Favorito: " + this.Favorito;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public bool retornaFavorito()
        {
            return this.Favorito;
        }


        public void Excluir()
        {
            this.Excluido = true;
        }

        public void Favoritar()
        {
            this.Favorito = true;
        }

        
    }
}