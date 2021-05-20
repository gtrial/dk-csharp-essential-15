namespace task02
{
    public struct Worker
    {
        public string FirstName { get; set; }
        public string Initials { get; set; }
        public string Position { get; set; }
        public int StartYear { get; set; }

        public Worker(string firstName, string initials, string position, int startYear)
        {
            FirstName = firstName;
            Initials = initials;
            Position = position;
            StartYear = startYear;
        }
    }
}