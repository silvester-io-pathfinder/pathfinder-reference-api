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
    public class MaskOfFear : Template
    {
        public static readonly Guid ID = Guid.Parse("e52354f3-84ff-4efe-98d9-8a3e4c01bc8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask of Fear",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this reaction even if you have a condition tied to the frightened condition that would normally prevent you from using a reaction, such as “fleeing as long as you're frightened” or “paralyzed as long as you're frightened.”",
                Trigger = "You start your turn with the frightened condition.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("280e93c6-f2ed-4fb0-b7ba-b75e25593113"), Type = TextBlockType.Text, Text = $"Your warmask burns off of your face, releasing your apprehension. You remove the frightened condition. Your warmask is destroyed, and you can't reapply it until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("86b714a7-dec2-4346-839f-2e8d81a02e4a"), Feats.Instances.OrcWarmask.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("153a85e3-4c02-4926-8af5-c1632e55f454"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
