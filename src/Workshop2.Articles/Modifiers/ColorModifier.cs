using System.Drawing;

namespace Workshop2.Articles.Modifiers;

public sealed class ColorModifier(Color color) : IRenderableModifier
{
    public string Modify(string value)
    {
        return Crayon.Output.Rgb(color.R, color.G, color.B).Text(value);
    }
}
