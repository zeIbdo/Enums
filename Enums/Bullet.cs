using Enums.Tempers;

namespace Enums;

public class Bullet
{
    private static int id;
    public int Id { get; private set; }
    public BulletTypes BulletType { get; set; }
    public Bullet(BulletTypes bullet)
    {
        Id = ++id;
        BulletType = bullet;
    }
    public override string ToString()
    {
        return $"{BulletType}";
    }
}
