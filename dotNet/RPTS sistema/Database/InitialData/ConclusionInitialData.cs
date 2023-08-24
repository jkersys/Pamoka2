using RPTS_sistema.Models;

namespace RPTS_sistema.Database.InitialData
{
    public class ConclusionInitialData
    {
        public static readonly Conclusion[] DataSeed = new Conclusion[] {
            new Conclusion
            {
               ConclusionId = 1,
               Decision = "Skundas atmestas"
            },
              new Conclusion
            {
               ConclusionId = 2,
               Decision = "Skundas priimtas"
            },
              new Conclusion
            {
               ConclusionId = 3,
               Decision = "Pažeidimų nenustatyta"
            },
               new Conclusion
            {
               ConclusionId = 4,
               Decision = "Nustatytas pažeidimas, pradėtas pažeidimo tyrimas"
            },
                new Conclusion
            {
               ConclusionId = 5,
               Decision = "Nustatytas pažeidimas, tačiau pažeidimo tyrimas nepradėtas, nes įmonė laikoma nauju ūkio subjektu"
            },
              new Conclusion
            {
               ConclusionId = 6,
               Decision = "Nutraukta dėl mažareikšmiškumo"
            },
               new Conclusion
            {
               ConclusionId = 7,
               Decision = "Pažeidimo tyrimas baigtas, byloje priimtas sprendimas skirti baudą"
            },
               new Conclusion
            {
               ConclusionId = 8,
               Decision = "Pažeidimo tyrimas baigtas, byloje priimtas tyrimą nutraukti"
            },
        };
    }
}