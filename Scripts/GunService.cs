// example class
// this class is binded in DI container via installer
public class GunServise : IBulletsGiver
{
    private Gun _currentGun;
    
    public void AddBullets(int bullets)
    {
        _currentGun.AddBullets(bullets);
    }
}