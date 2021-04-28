using System;

namespace Controle_de_Equipamentos___POO
{
    public class ListaEquipamentos
    {
        public Equipamento equipamento = new Equipamento();

        
        private string especificaçõesEquipamento;
        static private int equipamentosRegistrados = 0;
        private string[] equipamentos = new string[100];

        public void EditarEquipamentos(int idSelecionado)
        {           
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (idSelecionado == i)
                {
                    equipamento.Editar();
                }
            }
        }

      public void RegistrarEquipamentos()
        {
            Console.WriteLine("Insira o nome do equipamento registrado: ");
            string nome = Console.ReadLine();            

            Console.WriteLine("Insira o preço de aquisição do equipamento: ");
            int preço = Convert.ToInt32(Console.ReadLine());                    

            Console.WriteLine("Insira a data de fabricação do equipamento: ");
            DateTime dataDeFabricação = Convert.ToDateTime(Console.ReadLine());            

            Console.WriteLine("Insira o fabricante do equipamento:  ");
            string fabricante = Console.ReadLine();
            equipamentosRegistrados++;

            especificaçõesEquipamento = $"ID: {equipamento.idEquipamento} ,Equipamento: {nome}, Preço: {preço}, Fabricante: {fabricante}, " +
                $"Data de fabricação: {dataDeFabricação}.";            

            equipamentos[equipamentosRegistrados] = especificaçõesEquipamento;
                       
            equipamento.Fabricante = fabricante;
            equipamento.DataFabricação = dataDeFabricação;
            equipamento.PreçoAquisição = preço;
            equipamento.NomeEquipamento = nome;

        }

        public void ExcluirEquipamentos(int idSelecionado)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (idSelecionado == i)
                {
                     equipamento.NomeEquipamento = null;
                equipamento.PreçoAquisição = 0;
                equipamento.DataFabricação = DateTime.MinValue;
                equipamento.Fabricante = null;
                }
            }            
        }

        public void VisualizarEquipamentoEspecífico(int idSelecionado)
        {
          for (int i = 0; i < equipamentos.Length; i++)
            {
                if(idSelecionado == i)
                {
                    Console.WriteLine(equipamentos[i] );
                }
            }
        }

        public void VisualizarTodosEquipamentosRegistrados()
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {                
                if (equipamentos.Length != 0)
                {
                    Console.WriteLine(equipamentos[i]);
                }
                
            }
            Console.ReadLine();
           
        }
    }
}
