using Workshop2.Articles.Paragraphs.Builders;

namespace Workshop2.Articles.Paragraphs.Factories;

public sealed class DefaultBuilderFactory : IParagraphBuilderFactory
{
    public IParagraphBuilder Create()
    {
        return new DefaultParagraphBuilder();
    }
}
