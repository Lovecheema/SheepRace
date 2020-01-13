namespace SheepRace
{
    public static class Factory
    {
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Love();
                case 1: return new Dilpreet();
                case 2: return new Moto();
                default: return null;
            }
        }

    }
}
