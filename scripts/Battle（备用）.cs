//using Godot;

//public partial class Battle : Control
//{
//    [Signal]
//    public delegate void EndTurnRequestedEventHandler();

//    private Label _hpLabel = null!;
//    private Label _energyLabel = null!;
//    private Label _intentLabel = null!;

//    public override void _Ready()
//    {
//        _hpLabel = GetNode<Label>("PlayerArea/HP_Label");
//        _energyLabel = GetNode<Label>("PlayerArea/Energy_Label");
//        _intentLabel = GetNode<Label>("EnemyArea/EnemyPanel/Intent_Label");
//        GetNode<Button>("EndTurnButton").Pressed += OnEndTurnPressed;
//    }

//    public void SetPlayerState(int hp, int maxHp, int energy, int maxEnergy)
//    {
//        _hpLabel.Text = $"生命 {hp} / {maxHp}";
//        _energyLabel.Text = $"能量 {energy} / {maxEnergy}";
//    }

//    public void SetEnemyIntent(string intent)
//    {
//        _intentLabel.Text = $"意图：{intent}";
//    }

//    private void OnEndTurnPressed()
//    {
//        EmitSignal(SignalName.EndTurnRequested);
//    }
//}
