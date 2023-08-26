namespace Comuni.Web;

public class Styles
{
    public const string Button = $"text-{Colors.Background} bg-{Colors.Primary} hover:bg-{Colors.PrimaryLighter} border-{Colors.Primary} hover:border-{Colors.PrimaryLighter}";
    public const string ButtonOutlined = $"text-{Colors.Primary} hover:bg-{Colors.Primary} border-{Colors.Primary}";
    public const string DefaultLink = $"cursor-pointer text-sm text-{Colors.Primary600} hover:underline hover:text-{Colors.Primary}";
    public const string InverseLink = $"cursor-pointer underline hover:text-{Colors.Primary200}";

    public const string LabelStyle = $"text-sm font-semibold text-{Colors.TextSemiMuted}";
    public const string InputStyle = $"px-4 py-2 transition duration-500 border border-{Colors.TextLight} rounded focus:border-transparent focus:outline-none focus:ring-4 focus:ring-{Colors.Primary300}";
    public const string InputSmallStyle = $"text-sm px-3 py-1 transition duration-500 border border-{Colors.TextLight} rounded focus:border-transparent focus:outline-none focus:ring-2 focus:ring-{Colors.Primary300}";
    public const string ValidationMessageStyle = $"text-sm text-{Colors.Error} tracking-wide";
    
    public const string DefaultIconMesaures = "w-6 h-6";

    public const string SmallHeader = $"text-xl py-1 font-semibold text-{Colors.Primary} border-b-4 border-dashed border-{Colors.Primary500}";
    public const string TitleText = "uppercase tracking-widest font-medium";
    public const string Paragraph = $"text-md leading-relaxed";
}
