using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class ShootistBandolier : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("4070e631-7074-48fe-8bb7-00372e865dea");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Shootist Bandolier",
                Hands = "0",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d446cfa5-dfb4-4091-a7ca-5e048df92bf8"), Type = TextBlockType.Text, Text = "This leather bandolier holds up to three repeating hand crossbow magazines in leather pockets that pop open with the quick flick of a thumb. You reduce the reload time for a repeating hand crossbow magazine from the bandolier by 1, to a total of 2 actions. You can wear only one shootist bandolier at a time." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cf1e622-68e4-421e-a556-683b7a928785"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
