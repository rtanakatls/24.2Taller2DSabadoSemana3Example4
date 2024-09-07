using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoSemana3RPG
{
    internal class Game
    {
        private Player player;
        private List<Enemy> enemies;

        
        public void Execute()
        {
            CreatePlayer();
        }

        public void CreatePlayer()
        {
            bool continueFlag = true;
            Console.WriteLine("Introduce el nombre del jugador");
            string name = Console.ReadLine();
            int life = 0;
            int damage = 0;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la vida del jugador");
                life = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el daño del jugador");
                damage = int.Parse(Console.ReadLine());
                if (life < 0 || damage < 0 || life + damage > 100)
                {
                    Console.WriteLine("Los datos son inválidos");
                }
                else
                {
                    continueFlag = false;
                }
            }
            player=new Player(name,life,damage);
            Console.WriteLine($"Se creó a: {player.GetData()}");
        }


    }
}
