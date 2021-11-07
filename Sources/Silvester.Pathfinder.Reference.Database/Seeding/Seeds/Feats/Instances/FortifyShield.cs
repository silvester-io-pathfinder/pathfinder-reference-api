using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FortifyShield : Template
    {
        public static readonly Guid ID = Guid.Parse("868ae821-d715-405a-87a9-cda25c4ef43b");

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
            yield return new TextBlock { Id = Guid.Parse("02b6d6b7-991a-4d82-86ac-0213461112a9"), Type = TextBlockType.Text, Text = "You reinforce your shield with a rocky outgrowth of metal and stone. You (action: Raise your Shield | Raise a Shield). If you use the (feat: Shield Block) reaction before your next turn, add your character level to your shield’s Hardness when determining how much damage is blocked." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f96a8061-2662-4f66-b6f1-a743b9da6154"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c21d8a3-a24b-4e1a-8386-dd57aaa45bb3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
