using System.Drawing;
using Workshop2.Articles.Articles;
using Workshop2.Articles.Modifiers;
using Workshop2.Articles.Paragraphs;
using Workshop2.Articles.Paragraphs.Factories;
using Workshop2.Articles.Renderables;

IEnumerable<IParagraph> paragraphs = CreateParagraphs(new StyledParagraphBuilderFactory(new ColorModifier(Color.Green)));

IArticle article = new ArticleBuilder()
    .WithTitle(new Text("My article"))
    .AddParagraphs(paragraphs)
    .Build();

Console.WriteLine(article.Render());
Console.WriteLine("------------");

IArticleBuilder editBuilder = new ArticleBuilder();
editBuilder = article.Direct(editBuilder);

IArticle authoredArticle = editBuilder.WithAuthor(new Text("ronimizy").Dim()).Build();

Console.WriteLine(authoredArticle.Render());

static IEnumerable<IParagraph> CreateParagraphs(
    IParagraphBuilderFactory factory)
{
    return
    [
        CreateDefaultParagraph(factory.Create()),

        factory.Create()
            .WithHeader(new Text("Second"))
            .Build(),
    ];
}

static IParagraph CreateDefaultParagraph(IParagraphBuilder builder)
{
    return builder
        .WithHeader(new Text("Header").Bold().Colored(Color.Red))
        .AddContent(new Text("Abc1"))
        .AddContent(new Text("Abc2"))
        .AddContent(new Text("Abc3"))
        .Build();
}
