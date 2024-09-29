using backend.Models;
using Backend.Context;

namespace backend.src.Utils
{
    public class BonusCalculator
    {
        private readonly List<Bonus_tab> _bonusTabs;

        public BonusCalculator(ContextDB context)
        {
            _bonusTabs = context.Bonus_Tabs.OrderBy(b => b.min_range).ToList();
        }

        public decimal CalculateBonus(int points)
        {
            foreach (var bonusTab in _bonusTabs)
            {
                if (points >= bonusTab.min_range && points <= bonusTab.max_range)
                {
                    return bonusTab.bonus;
                }
            }
            return 0;
        }
    }

}
