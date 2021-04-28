namespace Controle_de_Equipamentos___POO
{
    public  class CriadorDeIDEquipamento
    {
        static int idAtual = 1;

        public static int IdAtual { get => idAtual; set => idAtual = value; }

      public  static int PegarID()
        {            
            return idAtual++;
        }

    }
}
