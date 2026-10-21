namespace Workshop2.Articles.Paragraphs;

public interface IParagraphBuilder
{
    IParagraphBuilder WithHeader(IRenderable header);

    IParagraphBuilder AddContent(IRenderable content);

    IParagraphBuilder WithFooter(IRenderable footer);

    IParagraph Build();
}
