using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskOfPower : Template
    {
        public static readonly Guid ID = Guid.Parse("fef8bae1-6a46-4360-bb78-2d11a11fceaa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask of Power",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5f316cf-a3a9-4f4a-81be-a320238aec61"), Type = TextBlockType.Text, Text = "Your warmask sharpens your connection to the source of your mask's power. During your daily preparations, choose (spell: fear), (spell: phantom pain), or (spell: true strike). Until your next daily preparations, you can cast this spell as a 1st-level innate spell once per day; the spell's tradition is determined by the tradition tied to your warmask. You must be wearing your warmask to (action: Cast the Spell | Cast a Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a8fb13f9-ae9e-4819-8f08-51cf84b8d292"), Feats.Instances.OrcWarmask.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b669126-9862-4152-b8e8-0dcdee7bdf33"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
