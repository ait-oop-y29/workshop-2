namespace Workshop2.Articles.Modifiers;

public sealed class BoldModifier : IRenderableModifier
{
    public string Modify(string value)
    {
        return Crayon.Output.Bold(value);
    }
}
