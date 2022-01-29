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
    public class SettlementScholastics : Template
    {
        public static readonly Guid ID = Guid.Parse("cfe61f7a-7d4b-4c18-b124-1585fc16ac97");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Settlement Scholastics",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. When you take this feat again, choose a different settlement.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8e84d97-c4ee-4cf2-9f00-1bb8ca578a8c"), Type = TextBlockType.Text, Text = $"Your studies open up new horizons. You become an expert in a Lore skill about a specific settlement; if you were already trained in that Lore skill, you also become trained in the Lore skill for a different settlement of your choice. Choose a single common or uncommon language prevalent in that settlement. You learn that language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8d89084b-358c-418b-aabb-0eb7b3032d78"), Feats.Instances.ArchaeologistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c238cd9-0efc-49e4-aa6f-b2e9ec82d9d1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
