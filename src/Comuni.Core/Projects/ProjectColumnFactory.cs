namespace Comuni.Core
{
    public class ProjectColumnFactory
    {
        public static ProjectColumn First => new ProjectColumn(1, 2, false);
        public static ProjectColumn Second => new ProjectColumn(2, 3, false);
        public static ProjectColumn Third => new ProjectColumn(3, 2, false);
        public static ProjectColumn Fourth => new ProjectColumn(4, 1, true);
        public static ProjectColumn Fifth => new ProjectColumn(5, 1, true, 3);
        public static ProjectColumn Sixth => new ProjectColumn(6, 2, false, 4);
        public static ProjectColumn Seventh => new ProjectColumn(7, 3, false, 5);
    }
}
