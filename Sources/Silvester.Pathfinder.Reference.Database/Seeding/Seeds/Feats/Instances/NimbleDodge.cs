using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NimbleDodge : Template
    {
        public static readonly Guid ID = Guid.Parse("a44e910c-579a-4ef0-ac8a-2458197e9e25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nimble Dodge",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature you can see targets you with an attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a569693-0d76-423c-81cc-7744c80a248f"), Type = TextBlockType.Text, Text = "You deftly dodge out of the way, gaining a +2 circumstance bonus to AC against the triggering attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5e17d47-33cb-4823-a034-e60223fc051c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
