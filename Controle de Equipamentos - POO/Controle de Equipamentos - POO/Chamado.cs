using System;

namespace Controle_de_Equipamentos___POO
{
    public class Chamado
    {
        CriadorDeIDChamado gerador = new CriadorDeIDChamado();

        public int idChamado = CriadorDeIDChamado.PegarID();
        private string tituloChamado;
        private string descriçãoChamado;
        private DateTime dataAberturaChamado;

        public string TituloChamado { get => tituloChamado; set => tituloChamado = value; }
        public string DescriçãoChamado { get => descriçãoChamado; set => descriçãoChamado = value; }
        public DateTime DataAberturaChamado { get => dataAberturaChamado; set => dataAberturaChamado = value; }

        public void Editar()
        {
            Console.WriteLine("Insira o título para ser editado: ");
            string tituloParaEditar = Console.ReadLine();

            Console.WriteLine("Insira a descrição a ser editada: ");
            string descriçãoParaEditar = Console.ReadLine();

            Console.WriteLine("Insira a data de abertura para editar: ");
            DateTime dataParaEditar = Convert.ToDateTime(Console.ReadLine());            

            TituloChamado = tituloParaEditar;
            descriçãoChamado = descriçãoParaEditar;
            DataAberturaChamado = dataParaEditar;

        }

    }
}
