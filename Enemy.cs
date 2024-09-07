using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoSemana3RPG
{
    internal class Enemy
    {
        private string name;
        private int life;
        private int damage;

        public Enemy(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

        public void TakeDamage(int damage)
        {
            life -= damage;
        }

        public int GetDamage()
        {
            return damage;
        }

        public string GetData()
        {
            return $"Enemy: {name}, HP: {life}, Daño: {damage}";
        }

        public bool IsAlive()
        {
            return life > 0;
        }
    }
}
