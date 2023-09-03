namespace FirstApp
{
    public abstract class Character : IMovie
    {
        public String Name { get; set; }
        public abstract void Movie();

        protected Character(String name)
        {
            this.Name = name;
        }
    }
}