using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousCuriosityArcane : Template
    {
        public static readonly Guid ID = Guid.Parse("a14971d4-88c3-4444-8ae2-14b871e139a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cautious Curiosity - Arcane",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69c484af-15c8-4e7e-90b1-b9c70a76a282"), Type = TextBlockType.Text, Text = "You gain (spell: misdirection) and (spell: silence) as 2nd-level arcane innate spells. You can cast each spell once per day and can target only yourself." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc97a126-ee38-460e-b6e5-a46146a9bd59"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
