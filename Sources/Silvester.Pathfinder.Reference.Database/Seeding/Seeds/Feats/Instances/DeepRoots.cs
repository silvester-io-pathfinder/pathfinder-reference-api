using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("042089ad-2379-4fed-bd10-00aae3e81d71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deep Roots",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72037e72-1bfd-479f-a744-d71c6ba850ec"), Type = TextBlockType.Text, Text = "Your insidious mind-control spells send burrowing mental roots so deep that they tear at your target’s mind even after they are removed or have run their course. When you cast a spell that imposes the controlled condition or otherwise forces the target to take certain actions (such as (spell: command)), you can choose one target who critically failed its save. When that target finishes fulfilling any commands issued by your spell, or when the spell is dispelled or counteracted, it takes 1d4 mental damage per level of the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea93cc44-1593-430d-828b-082278666edd"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
