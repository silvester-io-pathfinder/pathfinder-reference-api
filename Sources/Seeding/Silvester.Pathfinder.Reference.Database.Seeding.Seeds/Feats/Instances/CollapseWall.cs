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
    public class CollapseWall : Template
    {
        public static readonly Guid ID = Guid.Parse("b6834c87-18d6-442e-9817-9239a9dd937c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Collapse Wall",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature moves into the bombs' splash area.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6955e3d2-7cff-40a5-bc28-9d0d2246c38a"), Type = TextBlockType.Text, Text = $"You detonate the required bombs in order to bring a wall down on a creature. If your bombs deal enough damage to reduce the wall's Hit Points below its Broken Threshold, the wall partially collapses on the creature. The creature takes bludgeoning damage equal to the damage dealt to the wall (basic Reflex save; the DC for this save is equal to your class DC or spell DC, whichever is higher). On a failure, they must spend an Interact action to dig themselves out of the collapse, and on a critical failure, they must spend 2 Interact actions to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("02d3c6d0-9f01-4823-9758-10646d13ec09"), Feats.Instances.DemolitionistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4a5e61a-ed1a-450d-b911-e85ca850caa8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
