namespace Comuni.Core.Projects;

public class ProjectColumnFactory
{
    public static ProjectColumn First => new(1, 2, false);
    public static ProjectColumn Second => new(2, 3, false);
    public static ProjectColumn Third => new(3, 2, false);
    public static ProjectColumn Fourth => new(4, 1, true);
    public static ProjectColumn Fifth => new(5, 1, true, 3);
    public static ProjectColumn Sixth => new(6, 2, false, 4);
    public static ProjectColumn Seventh => new(7, 3, false, 5);
}
