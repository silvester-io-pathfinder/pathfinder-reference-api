using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class DwarvenGods : Template
    {
        public static readonly Guid ID = Guid.Parse("cfa57951-60a1-48eb-9ac7-ff5ac36c8b02");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            {
                Id = ID, 
                Name = "Dwarven Gods", 
                Description = "The dwarven gods are one large family, with Torag as its patriarch. He is joined by his brothers Magrim (the Taskmaster) and Angradd (the Forge Fire), his half-sister Dranngvit (the Debt Minder), and his wife Folgrit (the Watchful Mother). His children are Bolka (the Golden Gift), Grundinnar (the Peacemaker), Kols (the Oath-Keeper), and Trudd (the Mighty). Torag's evil former student Droskar (the Dark Smith), though technically part of the dwarven pantheon, is rarely invoked by any save duergars."
            };
        }
    }
}
