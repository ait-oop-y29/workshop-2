namespace Workshop2.Articles.Paragraphs.Builders;

public abstract class ParagraphBuilderBase : IParagraphBuilder
{
    private readonly List<IRenderable> _content = [];
    private IRenderable? _header;
    private IRenderable? _footer;

    protected IRenderable Header => _header ?? throw new InvalidOperationException("Header unspecified");

    protected IEnumerable<IRenderable> Content => _content.ToArray();

    protected IRenderable? Footer => _footer;

    public IParagraphBuilder WithHeader(IRenderable header)
    {
        _header = header;
        return this;
    }

    public IParagraphBuilder AddContent(IRenderable content)
    {
        _content.Add(content);
        return this;
    }

    public IParagraphBuilder WithFooter(IRenderable footer)
    {
        _footer = footer;
        return this;
    }

    public abstract IParagraph Build();
}
