using System;

namespace Controle_de_Equipamentos___POO
{
    class Menu
    {
        ListaEquipamentos lista = new ListaEquipamentos();        

        public void Iniciar() {
            Console.WriteLine("Controle de Equipamentos");
            Console.WriteLine("");
            Console.WriteLine("Opção 1 - Menu de Equipamentos");
            Console.WriteLine("Opção 2 - Menu de Chamados");
            string opçãoMenu = Console.ReadLine();

            if(opçãoMenu == "1")
            {
                MenuEquipamento();
            }
            if(opçãoMenu == "2")
            {
                MenuChamado();
            }

        }

        private void MenuSeleçãoEquipamentos(string opçãoSelecionada)
        {
            Console.WriteLine("Digite o ID do equipamento");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            if (opçãoSelecionada == "2" && idSelecionado == lista.equipamento.idEquipamento) 
            {
                lista.VisualizarEquipamentoEspecífico(idSelecionado);
                lista.ExcluirEquipamentos(idSelecionado);
            }
            if (opçãoSelecionada == "3" && idSelecionado == lista.equipamento.idEquipamento) 
            {
                lista.VisualizarEquipamentoEspecífico(idSelecionado);
                lista.EditarEquipamentos(idSelecionado);
            }
           
        }

        private void MenuEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Menu de Equipamentos");
            Console.WriteLine("");
            Console.WriteLine("Opção 1 - Registrar Equipamento");
            Console.WriteLine("Opção 2 - Excluir Equipamento");
            Console.WriteLine("Opção 3 - Editar Equipamento");
            Console.WriteLine("Opção 4 - Visualizar Lista de Equipamentos");
            string opçãoMenuEquipamento = Console.ReadLine();

            if(opçãoMenuEquipamento == "1")
            {
                Console.Clear();
                MenuCriarEquipamento();
            }
            if (opçãoMenuEquipamento == "2")
            {
                Console.Clear();
                MenuExcluirEquipamento(opçãoMenuEquipamento);
            }
            if (opçãoMenuEquipamento == "3")
            {
                Console.Clear();
                MenuEditarEquipamento(opçãoMenuEquipamento);
            }
            if (opçãoMenuEquipamento == "4")
            {
                Console.Clear();
                lista.VisualizarTodosEquipamentosRegistrados();
            }

        }

        private void MenuCriarEquipamento()
        { lista.RegistrarEquipamentos(); }

        private void MenuEditarEquipamento(string opçãoMenuEquipamento)
        {
            string opçãoSelecionada = opçãoMenuEquipamento;
           
            MenuSeleçãoEquipamentos(opçãoSelecionada);            }

        private void MenuExcluirEquipamento(string opçãoMenuEquipamento)
        {
            string opçãoSelecionada = opçãoMenuEquipamento;            
            MenuSeleçãoEquipamentos(opçãoSelecionada);           }

        private void MenuSeleçãoChamado(string opçãoSelecionada)
        {
            Console.WriteLine("Digite o ID do equipamento");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            if (opçãoSelecionada == "2" && idSelecionado == lista.equipamento.chamado.idChamado) 
            {
               lista.equipamento.ExcluirChamado(idSelecionado);
            }
            if (opçãoSelecionada == "3" && idSelecionado == lista.equipamento.chamado.idChamado) 
            {
               lista.equipamento.chamado.Editar();
            }
        }

        private void MenuChamado()
        {
            Console.Clear();
            Console.WriteLine("Menu de Chamados");
            Console.WriteLine("");
            Console.WriteLine("Opção 1 - Registrar Chamado");
            Console.WriteLine("Opção 2 - Excluir Chamado");
            Console.WriteLine("Opção 3 - Editar Chamado");
            Console.WriteLine("Opção 4 - Visualizar Lista de Chamados");
            string opçãoMenuChamado = Console.ReadLine();
        
            if(opçãoMenuChamado == "1")
            {
                MenuAbrirChamado(opçãoMenuChamado);
            }
            if(opçãoMenuChamado == "2")
            {
                MenuExcluirChamado(opçãoMenuChamado);
            }
            if (opçãoMenuChamado == "3")
            {
                MenuEditarChamado(opçãoMenuChamado);
            }
            if (opçãoMenuChamado == "4")
            {
              lista.equipamento.ListarTodosChamadosRegistrados();
            }
        }

        private void MenuAbrirChamado(string opçãoMenuChamado)
        {
            Console.Clear();
            lista.equipamento.AbrirChamado(opçãoMenuChamado); }

        private void MenuEditarChamado(string opçãoMenuChamado)
        {
            Console.Clear();
            lista.equipamento.ListarTodosChamadosRegistrados();
            MenuSeleçãoChamado(opçãoMenuChamado);                         }

        private void MenuExcluirChamado(string opçãoMenuChamado)
        {
            Console.Clear(); 
            lista.equipamento.ListarTodosChamadosRegistrados();
            MenuSeleçãoChamado(opçãoMenuChamado);                      }


    }
}
