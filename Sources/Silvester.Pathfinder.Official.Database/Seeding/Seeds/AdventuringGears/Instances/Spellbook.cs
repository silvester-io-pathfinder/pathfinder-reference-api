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
    public class Spellbook : Template
    {
        public static readonly Guid ID = Guid.Parse("b14bf18a-759f-4e77-9d24-b631f31797e5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Spellbook",
                Hands = "1",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("78ddb9c5-934d-4a09-90f1-c88dbc1b38f1"), Type = TextBlockType.Text, Text = "A spellbook holds the written knowledge necessary to learn and prepare various spells, a necessity for wizards (who typically get one for free) and a useful luxury for other spellcasters looking to learn additional spells. Each spellbook can hold up to 100 spells. The Price listed is for a blank spellbook." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d81d6b43-2329-41d6-980e-8e01c754f7e5"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
