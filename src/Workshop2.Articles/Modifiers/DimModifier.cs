namespace Workshop2.Articles.Modifiers;

public sealed class DimModifier : IRenderableModifier
{
    public string Modify(string value)
    {
        return Crayon.Output.Dim(value);
    }
}
