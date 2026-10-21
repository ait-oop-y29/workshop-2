using Workshop2.Articles.Modifiers;

namespace Workshop2.Articles.Renderables;

public interface IText : IRenderable
{
    string Value { get; }

    void AddModifier(IRenderableModifier modifier);
}

public interface IText<TSelf> : IText
    where TSelf : IText<TSelf>
{
    TSelf Clone();
}
