using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm scoring;

            Console.WriteLine("Erkek ;");
            scoring = new MenScoringAlgorithm();
            Console.WriteLine(scoring.GenerateScore(10, new TimeSpan(0,2,34)));

            Console.WriteLine("Kadın ;");
            scoring = new WomenScoringAlgorithm();
            Console.WriteLine(scoring.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("Çocuk ;");
            scoring = new ChildrenScoringAlgorithm();
            Console.WriteLine(scoring.GenerateScore(10, new TimeSpan(0, 2, 34)));


            Console.ReadLine();


        }
    }
    abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalaculateOverallScore(score, reduction);
        }

        public abstract int CalaculateOverallScore(int score, int reduction);

        public abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateBaseScore(int hits);
    
    }

    class MenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalaculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)(time.TotalSeconds / 5);

        }
    }

    class ChildrenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalaculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)(time.TotalSeconds / 2);

        }
    }

    class WomenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalaculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)(time.TotalSeconds / 3);

        }
    }
}
