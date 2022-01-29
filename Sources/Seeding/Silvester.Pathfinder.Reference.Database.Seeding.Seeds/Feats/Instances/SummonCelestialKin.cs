using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonCelestialKin : Template
    {
        public static readonly Guid ID = Guid.Parse("324e1bb2-f58f-41d7-9ed2-37d1e021e436");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Celestial Kin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3374b5bf-3914-42b2-8ff5-8129cedaff66"), Type = TextBlockType.Text, Text = $"You have a connection to the celestial realms, allowing you to summon a celestial ally. Once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("summon celestial", Spells.Instances.SummonCelestial.ID)} as a 5th-level divine innate spell, but the celestial summoned must be from the same category as your own lineage, such as a creature with the angel trait if you are angelkin." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("4beb9a3b-fa23-408c-ace5-fc7d74285a82"), Heritages.Instances.Aasimar.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13e061b5-b833-42d7-a3e7-bf735fb10917"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
