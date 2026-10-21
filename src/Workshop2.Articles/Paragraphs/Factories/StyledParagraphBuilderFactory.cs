using Workshop2.Articles.Modifiers;
using Workshop2.Articles.Paragraphs.Builders;

namespace Workshop2.Articles.Paragraphs.Factories;

public sealed class StyledParagraphBuilderFactory(
    IRenderableModifier modifier)
    : IParagraphBuilderFactory
{
    public IParagraphBuilder Create()
    {
        return new StyledParagraphBuilder(modifier);
    }
}
