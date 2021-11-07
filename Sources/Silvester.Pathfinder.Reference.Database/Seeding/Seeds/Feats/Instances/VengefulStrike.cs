using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VengefulStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("4f443c96-86a3-4221-b983-957bb0c5f82e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vengeful Strike",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach succeeds or critically succeeds at an attack against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bfd8e85a-393f-4155-8f63-af7f57fb3855"), Type = TextBlockType.Text, Text = "When struck by an enemy, you respond in turn. Make a melee (action: Strike) against the triggering creature. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83e2d068-0b68-4e34-b519-3c55bdbcc674"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
