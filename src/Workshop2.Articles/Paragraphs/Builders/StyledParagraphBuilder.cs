using Workshop2.Articles.Modifiers;

namespace Workshop2.Articles.Paragraphs.Builders;

public sealed class StyledParagraphBuilder(
    IRenderableModifier modifier)
    : ParagraphBuilderBase
{
    public override IParagraph Build()
    {
        return new ModifiableParagraph(
            new Paragraph(Header, Content, Footer),
            modifier);
    }
}
