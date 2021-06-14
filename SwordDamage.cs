namespace SwordDamageCalculator
{
    class SwordDamage
    {
        private const int Base_Damage = 3;
        private const int Flame_Damage = 2;
        private int roll;
        private bool magic;
        private bool flaming;
        public int Damage { get; private set; }

        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        public int Roll
        {
            get { return roll; }

            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
                magicMultiplier = 1.75M;

            Damage = Base_Damage;
            Damage = (int)(Roll * magicMultiplier) + Base_Damage;

            if (Flaming)
                Damage += Flame_Damage;
        }

        public bool Flaming
        {
            get { return flaming; }

            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        public bool Magic
        {
            get { return magic; }

            set
            {
                magic = value;
                CalculateDamage();
            }
        }
    }
}
