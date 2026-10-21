namespace Workshop2.Articles.Paragraphs.Builders;

public sealed class DefaultParagraphBuilder : ParagraphBuilderBase
{
    public override IParagraph Build() => new Paragraph(Header, Content, Footer);
}
