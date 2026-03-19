using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemys
{
    public class BossEnemyOne : BaseEnemy
    {
        public string BossWeaponName { get; set; }
        public int BossWeaponHitPower { get; set; }
        public BossEnemyOne(string weapon, int weaponPower,string name, int health, int lives, string catchPhrase, int hitpower) : base(name, health, lives, catchPhrase, hitpower)
        {
            BossWeaponName = weapon;
            BossWeaponHitPower = weaponPower;
            EnemyName = name; 
            EnemyHeatlh = health;
            EnemyLives = lives;
            CatchPhrase = catchPhrase;
            EnemyHitPower = hitpower;
        }
    }
}
