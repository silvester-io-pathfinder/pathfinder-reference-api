using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SelfishShield : Template
    {
        public static readonly Guid ID = Guid.Parse("ea866b3c-e51b-492c-9242-35f86edec5c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Selfish Shield",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within 15 feet damages you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("518dd69f-9aac-449b-a62c-62e5ad35d0da"), Type = TextBlockType.Text, Text = "Your self-interest keeps you safe. You gain resistance against the triggering damage equal to 2 + half your level, regardless of damage type." };
            yield return new TextBlock { Id = Guid.Parse("bc46123b-cb23-4fd3-a6dc-cb437642f9ec"), Type = TextBlockType.Text, Text = "In addition, your (action: Strikes | Strike) against the triggering creature deal 1 extra damage until the end of your next turn. You choose whether this extra damage is evil or negative each time you use this reaction. This extra damage increases to 2 at 9th level and 3 at 16th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("613c81d6-f879-4cb8-971e-70bff321d8bb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
