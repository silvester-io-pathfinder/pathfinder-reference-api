using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LockOn : Template
    {
        public static readonly Guid ID = Guid.Parse("16cc6f89-2c51-481a-8e7d-c8e39129ea4c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lock On",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab2e54d6-1801-496b-9e8e-017ddde6b1d8"), Type = TextBlockType.Text, Text = "Aha! You lock on to your enemy’s weak point to assist your construct companion in destroying it. When you Lock On, designate an enemy you can see. If your next action is to Command your construct, the construct gains a +2 circumstance bonus to attack rolls against the designated enemy until the end of the turn. If you use 2 actions for the Command, the bonus is instead a +3 circumstance bonus, or a +4 circumstance bonus if you’re legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("25858548-dc33-4515-a8f9-a2ebd4446b82"), Innovations.Instances.Construct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0dee59e-2f9b-415f-96cc-4018cb179fe3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
