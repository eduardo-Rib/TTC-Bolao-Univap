using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolão_Univap
{
    internal class ArrayParticipantes
    {
        private Participante[] ArrayParticipante = new Participante[1000];
        private int Num_Participantes = 0;

        //------------------------------------Adiciona um nome participante no Array de Participantes------------------------------------
        public void setArrayParticipantes(string id, string nome, string pontos, string AcertosExatos, string AcertosClsssicos, string precisaoAcertos, string NumPalpites, string NumAcertos)
        {
            Participante participante = new Participante(id, nome, pontos, AcertosExatos, AcertosClsssicos, precisaoAcertos, NumPalpites, NumAcertos);
            this.ArrayParticipante[getNum_Participantes()] = participante;
            setNum_Participantes(1);
        }

        //------------------------------------Altera o numero de participantes no Array------------------------------------
        public void setNum_Participantes(int i)
        {
            this.Num_Participantes = getNum_Participantes() + i;
        }

        //------------------------------------Coleta o numero de participantes no Array------------------------------------
        public int getNum_Participantes()
        {
            return this.Num_Participantes;
        }

        //------------------------------------Returna um Participante na posição passada------------------------------------
        public Participante getParticipante(int i) 
        {
            return ArrayParticipante[i];
        }
    }
}