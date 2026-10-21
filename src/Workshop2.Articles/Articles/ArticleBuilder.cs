using Workshop2.Articles.Paragraphs;

namespace Workshop2.Articles.Articles;

public sealed class ArticleBuilder : IArticleBuilder
{
    private readonly List<IParagraph> _paragraphs = [];
    private IRenderable? _title;
    private IRenderable? _author;

    public IArticleBuilder WithTitle(IRenderable title)
    {
        _title = title;
        return this;
    }

    public IArticleBuilder AddParagraph(IParagraph paragraph)
    {
        _paragraphs.Add(paragraph);
        return this;
    }

    public IArticleBuilder AddParagraphs(IEnumerable<IParagraph> paragraphs)
    {
        _paragraphs.AddRange(paragraphs);
        return this;
    }

    public IArticleBuilder WithAuthor(IRenderable author)
    {
        _author = author;
        return this;
    }

    public IArticle Build()
    {
        return new Article(
            _title ?? throw new InvalidOperationException("Title unspecified"),
            _paragraphs.ToArray(),
            _author);
    }
}
