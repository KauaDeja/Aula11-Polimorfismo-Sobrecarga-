namespace Aula11_Polimorfismo
{
    public class Calculo
    {
           public string Calcular(){            
            return "Não houve nenhum calculo a ser aplicado";
        }

        public string Calcular(int habilidade){
            return "A habilidade do jogador é de "+habilidade;
        }

        public string Calcular(int vida, int passiva){
            return "A vida do jogador com passiva é "+ (vida+passiva);
        }

        public string Calcular(string nome, string titulo){
            return $"O {nome} está {titulo}";
        }    
    }
}