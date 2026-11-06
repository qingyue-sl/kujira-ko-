using Godot;

[GlobalClass]
public partial class CardData : Resource
{
	public enum CardType { Attack, Defend, Skill, Status }
	public enum EffectType { Damage, Block, Draw, Weak, Strength}
	
	[Export] public string CardName { get; set; } = "";                  // 卡牌名称
	[Export] public int Cost { get; set; } = 1;                          // 卡牌消耗
	[Export] public CardType Type { get; set; } = CardType.Attack;       // 卡牌类型
	[Export] public EffectType effect { get; set; } = EffectType.Damage; // 卡牌效果
	[Export] public int value { get; set; } = 0;                         // 卡牌数值
	[Export] public string Description { get; set; } = "";               // 卡牌说明
	[Export] public Texture2D Art { get; set; }                          // 卡牌牌面
}
