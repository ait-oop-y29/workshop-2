using System.Text;

namespace Workshop2.Articles.Paragraphs;

public sealed class Paragraph(
    IRenderable header,
    IEnumerable<IRenderable> content,
    IRenderable? footer)
    : IParagraph
{
    public string Render()
    {
        var builder = new StringBuilder();

        builder.AppendLine(header.Render());

        foreach (IRenderable renderable in content)
        {
            builder.AppendLine(renderable.Render());
        }

        if (footer is not null)
        {
            builder.AppendLine(footer.Render());
        }

        return builder.ToString();
    }
}
