using System.Drawing;
using Workshop2.Articles.Modifiers;

namespace Workshop2.Articles.Renderables;

public static class TextExtensions
{
    extension<T>(T text)
        where T : IText<T>
    {
        public T Colored(Color color)
        {
            T clone = text.Clone();
            clone.AddModifier(new ColorModifier(color));

            return clone;
        }

        public T Bold()
        {
            T clone = text.Clone();
            clone.AddModifier(new BoldModifier());

            return clone;
        }

        public T Dim()
        {
            T clone = text.Clone();
            clone.AddModifier(new DimModifier());

            return clone;
        }
    }
}
