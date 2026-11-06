using Godot;

[GlobalClass]
public partial class EnemyData : Resource
{
    public enum Intent { Attack, Defend, Buff }

    public string EnemyNamr { get; set; } = "";
    public int Hp { get; set; } = 20;
    public int AttackValue { get; set; } = 5;
    public int DefendValue { get; set; } = 5;
    public Texture2D Art { get; set; }
}
