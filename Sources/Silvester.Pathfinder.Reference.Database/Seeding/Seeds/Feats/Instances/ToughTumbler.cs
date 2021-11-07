using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToughTumbler : Template
    {
        public static readonly Guid ID = Guid.Parse("688d689d-79e6-4708-8139-dffb175eaf32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tough Tumbler",
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
            yield return new TextBlock { Id = Guid.Parse("41e973b3-5dd5-4655-9c93-0f60a9fea41b"), Type = TextBlockType.Text, Text = "You’ve taken your share of licks while scurrying around the battlefield and know how to defend yourself against opportunistic attackers. Your movement ends only when you critically fail an Acrobatics check to (Action: Tumble Through) an enemy’s space (or when you don’t have enough Speed to move all the way through its space). You still trigger reactions on a failure to (Action: Tumble Through), but you gain a +1 circumstance bonus to AC against attacks that you trigger in this way." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc7c7206-cc76-4f65-8d61-3e7544a82c0f"), Feats.Instances.ScamperUnderfoot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2715ed7-2805-454a-8dc3-d772d03e8551"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
