using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FortifyShield : Template
    {
        public static readonly Guid ID = Guid.Parse("17e99e90-b4cb-494a-8719-cb5d61300712");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fortify Shield",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cbd407e8-ed60-425a-8a70-a8a68d44e4db"), Type = TextBlockType.Text, Text = "You reinforce your shield with a rocky outgrowth of metal and stone. You (action: Raise your Shield | Raise a Shield). If you use the (feat: Shield Block) reaction before your next turn, add your character level to your shield’s Hardness when determining how much damage is blocked." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ef25f4c9-cf2d-471e-ba08-f4875c509131"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c59374e8-7a19-44f5-a3df-467db662012d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
