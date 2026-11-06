using Godot;

public partial class Card : PanelContainer
{
    private CardData _data;
    private Label _nameLabel;
    private Label _costLabel;
    private Label _descLabel;


    public override void _Ready()
    {
        _nameLabel = GetNode<Label>("VBox/NameLabel");
        _costLabel = GetNode<Label>("VBox/CostLabel");
        _descLabel = GetNode<Label>("VBox/DescLabel");
    }

    public void Setup(CardData cardData)
    {
        _data = cardData;
        _nameLabel.Text = cardData.CardName;
        _costLabel.Text = cardData.Cost.ToString();
        _descLabel.Text = cardData.Description;
    }

}
