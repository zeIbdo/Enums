using Enums.Tempers;
using System.Threading.Tasks.Sources;

namespace Enums;

public class Weapon
{
    private static int id;
    public int Id { get; private set; }
    public List<Bullet> Bullets { get; private set; }
    public int Capacity { get; set; }
    public Weapon(int capacity)
    {
        Id = ++id;
        Bullets = new List<Bullet>();
        Capacity = capacity;
    }
    public void Fire()
    {
        if (Bullets.Count == 0)
        {
            Console.WriteLine("You don't have ammo for this shot.");
        }
        else
        {
            Bullet firedBullet = Bullets[0];
            Console.WriteLine($"Next bullet to be fired: {firedBullet}");
        System.Threading.Thread.Sleep(2500);
            Bullets.RemoveAt(0);
            Console.WriteLine($"Shot fired! Now you have {Bullets.Count} bullets left. Fired Bullet: {firedBullet}");
        }

    }
    public void Fill(BulletTypes bullet, int ammo)
    {
        if (Bullets.Count + ammo > Capacity)
        {
            Console.WriteLine("Cannot fill beyond capacity.");
        }
        else
        {
            for (int i = 0; i < ammo; i++)
            {
                Bullets.Add(new Bullet(bullet));
            }
            Console.WriteLine($"Now you have loaded {ammo} ammo {bullet} type.");
        }
    }
    public void PullTrigger()
    {
        if (Bullets.Count == 0)
        {
            Console.WriteLine("No bullets to fire.");
        }
        else
        {
            Bullet nextBullet = Bullets[0];
            Console.WriteLine($"Next bullet to be fired: {nextBullet}");
        }
    }
}
