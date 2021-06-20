namespace Comuni.Core
{

    public record GuildMaster
    {
        private readonly string name;
        public Resource Reward { get; }

        public GuildMaster(string name, Resource reward)
        {
            this.name = name;
            Reward = reward;
        }

        public override string ToString() => name;
    }


}
