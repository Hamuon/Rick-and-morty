namespace FirstApp
{
    public class Morty : Character
    {

        private Position position;
        private Ability ability1;
        public Ability ability
        {
            get
            {
                return ability1;
            }

            set
            {
                ability1 = value;
            }
        }

        public Morty(String name, Position position, Ability ability) : base(name)
        {
            this.position = position;
            this.ability = ability;
        }

        public override void Movie()
        {
            Console.WriteLine("Morty has the name " + Name
             + "\n and Also with the \n" +
            "Position: " + position.ToString() + '\n' +
            "Ability: " + ability.ToString());
        }

        public String GetPosition()
        {
            return position.ToString();
        }

        public void SetPosition(Position position)
        {
            this.position = position;
        }

        public override string ToString()
        {
            return "Morty is going to fuck " + Name + '\n'
            + "With the style of " + position + '\n' +
            "And With abiltiy of " + ability1;
        }

    }
}