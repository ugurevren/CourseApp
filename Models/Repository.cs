namespace CourseApp.Models{
    public static class Repository{
        private static List<Candidate> candidates = new ();
        public static IEnumerable<Candidate> Candidates => candidates;
        public static void Add(Candidate candidate){
            candidates.Add(candidate);
        }
    
    }
}