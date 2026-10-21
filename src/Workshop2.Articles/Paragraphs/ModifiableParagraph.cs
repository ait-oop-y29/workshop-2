using Workshop2.Articles.Modifiers;

namespace Workshop2.Articles.Paragraphs;

public sealed class ModifiableParagraph(
    IParagraph paragraph,
    IRenderableModifier modifier)
    : IParagraph
{
    public string Render()
    {
        return modifier.Modify(paragraph.Render());
    }
}
