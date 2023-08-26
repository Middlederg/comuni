using System.Drawing;

namespace Comuni.Web.Extensions;

public static class ColorExtensions
{
    public static string ToHex(this Color color) => "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
}
