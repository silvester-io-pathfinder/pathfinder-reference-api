using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FavorOfHeaven : Template
    {
        public static readonly Guid ID = Guid.Parse("1a3bc24b-1a78-4b25-bee9-e20c44253021");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Favor of Heaven",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9492531-4787-4a63-8fe6-2c6068cb5eb3"), Type = TextBlockType.Text, Text = $"You're one of Hei Feng's chosen people and have the authority of the Celestial Court on your side. Once per day, you can cast a 6th-level {ToMarkdownLink<Models.Entities.Spell>("spirit blast", Spells.Instances.SpiritBlast.ID)} as a divine innate spell. In addition, you gain resistance 5 to both good and evil damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c039b92-c646-467b-a461-b1cea2fae2f0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
