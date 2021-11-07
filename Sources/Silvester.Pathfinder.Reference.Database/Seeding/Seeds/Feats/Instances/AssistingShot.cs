using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssistingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("91bec5f0-bd5c-44ef-a01c-7b593cdb4cb1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assisting Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7eaf6268-5658-4005-b460-7e768934c9ed"), Type = TextBlockType.Text, Text = "With a quick shot, you interfere with a foe in combat. Make a (action: Strike) with a ranged weapon. If the strike hits, the next creature other than you to attack the same target before the start of your next turn gains a +1 circumstance bonus on their roll, or a +2 circumstance bonus if your (action: Strike) was a critical hit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4f27b87-d01a-4a35-b5fb-37b4237633f4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
