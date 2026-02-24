using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolão_Univap
{
    internal class Participante
    {
        private string nome;
        private int pontos;
        private int id;
        private int AcertosExatos;
        private int AcertosClassicos;
        private float Precisao;
        private int NumPalpites;
        private int NumAcertos;


        //----------------------CONSTRUTOR---------------------------
        public Participante(string id, string nome, string pontos, string AcertosExatos, string AcertosClsssicos, string Precisao, string NumPalpites, string NumAcertos) 
        {
            this.setNome(nome);
            this.setId(id);
            this.setPontos(pontos);
            this.setAcertosExatos(AcertosExatos);
            this.getAcertosClassicos(AcertosClsssicos);
            this.setPrecisao(Precisao);
            this.setNumPalpites(NumPalpites);
            this.setNumAcertos(NumAcertos);
        }

        //-------------------------TODOS OS SET'S-----------------------
        public void setNome(string valor)
        {
            this.nome = valor;
        }

        public void setId(string valor)
        {
            this.id = int.Parse(valor);
        }

        public void setPontos(string valor)
        {
            this.pontos = int.Parse(valor);
        }

        public void setAcertosExatos(string valor)
        {
            this.AcertosExatos = int.Parse(valor);
        }

        public void getAcertosClassicos(string valor) 
        { 
            this.AcertosClassicos = int.Parse(valor);
        }

        public void setPrecisao(string valor)
        {
            this.Precisao = float.Parse(valor);
        }

        public void setNumPalpites(string valor)
        {
            this.NumPalpites = int.Parse(valor);
        }

        public void setNumAcertos(string valor)
        {
            this.NumAcertos = int.Parse(valor);
        }


        //-----------------TODOS OS GET'S----------------------
        public string getNome()
        {
            return this.nome;
        }

        public int getId()
        {
            return this.id;
        }

        public int getPontos()
        {
            return this.pontos;
        }

        public int getAcertosExatos()
        {
            return this.AcertosExatos;
        }

        public int getAcertosClassicos()
        {
            return this.AcertosClassicos;
        }

        public int getNumPalpites()
        {
            return this.NumPalpites;
        }

        public int setNumAcertos()
        {
            return this.NumAcertos;
        }
    }
}