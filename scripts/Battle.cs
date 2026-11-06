using Godot;

public partial class Battle : Control
{
    private int _playerHp = 50;
    private int _playerMaxHp = 50;
    private int _energy = 3;
    [Export] public PackedScene CardScene { get; set; }

    private Label _hpLabel;
    private Label _energyLabel;

    public override void _Ready()
    {
        _hpLabel = GetNode<Label>("PlayerArea/HP_Label");
        _energyLabel = GetNode<Label>("PlayerArea/Energy_Label");
        UpdateUi();

        // 临时测试
        var textCard = new CardData
        {
            CardName = "打击",
            Cost = 1,
            Description = "造成6点伤害"
        };
        var cardUi = CardScene.Instantiate();
        GetNode("HandArea").AddChild(cardUi);
        cardUi.Call("Setup",textCard);

    }

    private void UpdateUi()
    {
        _hpLabel.Text = $"HP：{_playerHp} / {_playerMaxHp}";
        _energyLabel.Text = $"EP：{_energy} / 3";
    }
}
