namespace StudentMinMax
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public int? GetMaximumScore()
        {
            int maximumScore = Scores[0];
            
            for (int i = 1; i < Scores.Length; i++)
            {
                if (Scores[i] > maximumScore)
                {
                    maximumScore = Scores[i];
                }
            }

            return maximumScore;

        }

        public int? GetMinimumScore()
        {
            int minimumScore = Scores[0];
            for (int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] < minimumScore)
                {
                    minimumScore = Scores[i];
                }
                
            }

            return minimumScore;
        }
    }
}