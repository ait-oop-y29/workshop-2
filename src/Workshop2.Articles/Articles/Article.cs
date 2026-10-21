using System.Text;
using Workshop2.Articles.Paragraphs;

namespace Workshop2.Articles.Articles;

public sealed class Article(
    IRenderable title,
    IEnumerable<IParagraph> paragraphs,
    IRenderable? author)
    : IArticle
{
    public IArticleBuilder Direct(IArticleBuilder builder)
    {
        builder = builder
            .WithTitle(title)
            .AddParagraphs(paragraphs);

        if (author is not null)
        {
            builder = builder.WithAuthor(author);
        }

        return builder;
    }

    public string Render()
    {
        var builder = new StringBuilder();

        builder.AppendLine(title.Render());
        builder.AppendLine();
        builder.AppendLine();

        foreach (IParagraph paragraph in paragraphs)
        {
            builder.AppendLine(paragraph.Render());
        }

        if (author is not null)
        {
            builder.AppendLine(author.Render());
        }

        return builder.ToString();
    }
}
