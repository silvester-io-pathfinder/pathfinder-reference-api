using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("78ddb9c5-934d-4a09-90f1-c88dbc1b38f1"), "A spellbook holds the written knowledge necessary to learn and prepare various spells, a necessity for wizards (who typically get one for free) and a useful luxury for other spellcasters looking to learn additional spells. Each spellbook can hold up to 100 spells. The Price listed is for a blank spellbook.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fcfd4eab-d9cb-46b4-92a2-e9db045bcfc3"),
                Name = "Spellbook (Blank)",
                Hands = "1",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d81d6b43-2329-41d6-980e-8e01c754f7e5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
