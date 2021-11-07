using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineAegis : Template
    {
        public static readonly Guid ID = Guid.Parse("d0a6e230-2c4f-4472-9dcc-cffddc522588");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Aegis",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a magical effect, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a50fff30-3a11-4957-977c-0f8c77d5058a"), Type = TextBlockType.Text, Text = "You summon divine energy to shield yourself, offering protection against other traditions but leaving you exposed to other (trait: divine) effects. Until the beginning of your next turn, you gain a +1 circumstance bonus to saving throws against non-divine magical effects, but you also take a -1 circumstance penalty to saves against (trait: divine) effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdfd7d47-0a7a-40a0-ac1e-994775ff9d67"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
