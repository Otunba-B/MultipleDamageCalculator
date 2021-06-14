namespace SwordDamageCalculator
{
    class ArrowDamage
    {
        private const decimal Base_Multiplier = 0.35M;
        private const decimal Magic_Multiplier = 0.35M;
        private const decimal Flame_Damage = 1.25M;
        private int roll;
        private bool magic;
        private bool flaming;
        public int Damage { get; private set; }

        public ArrowDamage(int startingRoll)
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
            decimal baseDamage = Roll * Base_Multiplier;
            if (Magic)
                baseDamage *= Magic_Multiplier;

            if (Flaming)
                Damage = (int) Math.Ceiling(baseDamage + Flame_Damage);
            else
                Damage = (int) Math.Ceiling(baseDamage);
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
