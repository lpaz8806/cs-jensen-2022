namespace L10DesignPrinciples.DesignPatterns;

class App
{
    public static void Run()
    {
        int difficulty = int.Parse(Console.ReadLine());
        var factory = EasyEnemyFactory.Instance;
        var factory2 = EasyEnemyFactory.Instance;
        StartGame(factory);
    }
    public static void StartGame(IEnemyFactory factory)
    {
        IEnemy[] enemies = new IEnemy[2];

        enemies[0] = factory.CreatePinky();
        enemies[1] = factory.CreateZombie();

    }
}



interface IEnemyFactory
{
    IEnemy CreateZombie();
    IEnemy CreatePinky();
}

sealed class EasyEnemyFactory : IEnemyFactory
{
    private static EasyEnemyFactory _instance = new();

    public static EasyEnemyFactory Instance => _instance;
    
    private EasyEnemyFactory() { }
    public IEnemy CreateZombie() => new Zombie(1);
    public IEnemy CreatePinky()=> new Pinky(5);
}

class HardEnemyFactory : IEnemyFactory
{
    public IEnemy CreateZombie() => new Zombie(3);
    public IEnemy CreatePinky()=> new Pinky(7);
}



interface IEnemy
{
    void Attack();
}

class Pinky : IEnemy
{
    private int _damage;
    public Pinky(int damage) => _damage = damage;

    public void Attack()
        => Console.WriteLine( $"Pinky took {_damage} hp from you");
}

class Zombie : IEnemy
{
    private int _damage;
    public Zombie(int damage) => _damage = damage;

    public void Attack() => 
        Console.WriteLine( $"Zombie took {_damage} hp from you");
}