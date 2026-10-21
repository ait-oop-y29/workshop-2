using Workshop2.Articles.Paragraphs;

namespace Workshop2.Articles.Articles;

public interface IArticleBuilder
{
    IArticleBuilder WithTitle(IRenderable title);

    IArticleBuilder AddParagraph(IParagraph paragraph);

    IArticleBuilder AddParagraphs(IEnumerable<IParagraph> paragraphs);

    IArticleBuilder WithAuthor(IRenderable author);

    IArticle Build();
}
