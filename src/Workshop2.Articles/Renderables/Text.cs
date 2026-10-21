using Workshop2.Articles.Modifiers;

namespace Workshop2.Articles.Renderables;

public sealed class Text : IText<Text>
{
    private readonly List<IRenderableModifier> _modifiers;

    public Text(string value)
    {
        Value = value;
        _modifiers = [];
    }

    private Text(string value, IEnumerable<IRenderableModifier> modifiers)
    {
        Value = value;
        _modifiers = modifiers.ToList();
    }

    public string Value { get; set; }

    public void AddModifier(IRenderableModifier modifier)
    {
        _modifiers.Add(modifier);
    }

    public Text Clone()
    {
        return new Text(Value, _modifiers);
    }

    public string Render()
    {
        return _modifiers.Aggregate(
            Value,
            (value, modifier) => modifier.Modify(value));
    }
}
