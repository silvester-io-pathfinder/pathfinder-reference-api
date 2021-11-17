using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MastermindsEye : Template
    {
        public static readonly Guid ID = Guid.Parse("2382f11f-8a6a-4490-9ebf-1bcfa36723d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mastermind's Eye",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d265bc4e-3dfa-4de6-bd91-e66569f43267"), Type = TextBlockType.Text, Text = "When you succeed at identifying a creature using (action: Recall Knowledge), that creature is flat-footed against your attacks until the start of your next turn; if you critically succeed, it&#39;s flat-footed against your attacks for 1 minute. This feat serves as the rogue&#39;s mastermind racket for the purpose of meeting prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("388e25d2-cf6f-4eeb-8c4b-5b8755e31bea"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
