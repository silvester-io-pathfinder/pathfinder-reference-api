using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RetributiveStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("a5320ef3-5709-49b4-8b34-5c09a8da43f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Retributive Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy damages your ally, and both are within 15 feet of you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c6eab17-c0f4-44e7-a56e-a10cedd913d8"), Type = TextBlockType.Text, Text = "You protect your ally and strike your foe. The ally gains resistance to all damage against the triggering damage equal to 2 + your level. If the foe is within reach, make a melee (action: Strike) against it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd3c9b9f-0b8e-494c-920d-41f981b8c141"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
