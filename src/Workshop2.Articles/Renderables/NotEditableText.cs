using Workshop2.Articles.Modifiers;

namespace Workshop2.Articles.Renderables;

public sealed class NotEditableText(string value) : IText<NotEditableText>
{
    public string Value { get; } = value;

    public NotEditableText Clone()
    {
        return new NotEditableText(Value);
    }

    public string Render()
    {
        return Value;
    }

    public void AddModifier(IRenderableModifier modifier) { }
}
