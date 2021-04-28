using System;

namespace Controle_de_Equipamentos___POO
{
    public class Equipamento
    {
        CriadorDeIDEquipamento gerador = new CriadorDeIDEquipamento();
        public Chamado chamado = new Chamado();
        

        private string[] chamados = new string[100];
        public int idEquipamento = CriadorDeIDEquipamento.PegarID();
        private string nomeEquipamento;
        private DateTime dataFabricação;
        private int preçoAquisição;
        private string fabricante;
        private string numeroDeSérie;
        private int contadorChamados;
        string descriçãoChamado;


      public string[] Chamados { get => chamados; set => chamados = value; }        
      public string NomeEquipamento { get => nomeEquipamento; set => nomeEquipamento = value; }
      public DateTime DataFabricação { get => dataFabricação; set => dataFabricação = value; }
      public int PreçoAquisição { get => preçoAquisição; set => preçoAquisição = value; }
      public string Fabricante { get => fabricante; set => fabricante = value; }
      public string NumeroDeSérie { get => numeroDeSérie; set => numeroDeSérie = value; }

        public void Editar()
        {
            Console.WriteLine("Insira o nome do equipamento para editar: ");
            string nomeParaEditar = Console.ReadLine();
            
            Console.WriteLine("Insira o preço de aquisição do equipamento: ");
            int preçoParaEditar = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Insira a data de fabricação do equipamento: ");
            DateTime dataParaEditar = Convert.ToDateTime(Console.ReadLine());           

            Console.WriteLine("Insira o fabricante do equipamento:  ");
            string fabricanteParaEditar = Console.ReadLine();   

            NomeEquipamento = nomeParaEditar;
            PreçoAquisição = preçoParaEditar;
            DataFabricação = dataParaEditar;
            Fabricante = fabricanteParaEditar;
        }

        public void AbrirChamado(string opçãoMenuChamado)
        {
            Console.WriteLine("Digite o título do chamado: ");
            string titulo = Console.ReadLine();
            
            Console.WriteLine("Insira a descrição do chamado: ");
            string descrição = Console.ReadLine();            

            Console.WriteLine("Insira a data de abertura do chamado");
            DateTime data = Convert.ToDateTime(Console.ReadLine());            

            DateTime hoje = DateTime.Now;
            TimeSpan diferença = hoje.Subtract(data);
            int mostraDiferença = Convert.ToInt32(diferença.TotalDays);

            descriçãoChamado = $"ID: {chamado.idChamado}, Título do chamado: {titulo}, Equipamento: {NomeEquipamento}, Data de abertura: {data}, " +
                $"Está aberto a {mostraDiferença-1} dias";

            contadorChamados++;
            chamados[contadorChamados] = descriçãoChamado;

            chamado.TituloChamado = titulo;
            chamado.DescriçãoChamado = descrição ;    
            chamado.DataAberturaChamado = data;
        }

        public void ExcluirChamado(int idSelecionado)
        {   for (int i = 0; i < chamados.Length; i++)
            {
                if (idSelecionado == i)
                {
                    chamado.TituloChamado = null;
                    chamado.DescriçãoChamado = null;
                    chamado.DataAberturaChamado = DateTime.MinValue;
                }
            }

        }

        public void ListarTodosChamadosRegistrados()
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados.Length != 0)
                {
                    Console.WriteLine(chamados[i]);
                }else
                {
                    Console.WriteLine("Nenhum chamado registrado.");
                }
                
            }
            Console.ReadLine();
        }

        public void ConsultarChamadoEspecífico(int idSelecionado)
        {            
            for (int i = 0; i < chamados.Length; i++)
            {
                if (idSelecionado == i)
                {
                    Console.WriteLine(chamados[i]);
                }
            }
        }



    }
}
