namespace Comuni.Core
{
    public class ProjectColumnFactory
    {
        public ProjectColumn First => new ProjectColumn(1, 2, false);
        public ProjectColumn Second => new ProjectColumn(2, 3, false);
        public ProjectColumn Third => new ProjectColumn(3, 2, false);
        public ProjectColumn Fourth => new ProjectColumn(4, 1, true);
        public ProjectColumn Fifth => new ProjectColumn(5, 1, true, 3);
        public ProjectColumn Sixth => new ProjectColumn(6, 2, false, 4);
        public ProjectColumn Seventh => new ProjectColumn(7, 3, false, 5);
    }
}
