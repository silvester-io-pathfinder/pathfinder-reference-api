using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResistRuin : Template
    {
        public static readonly Guid ID = Guid.Parse("32641b98-c358-4d5d-ab5a-c89e4fc45d85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resist Ruin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("139c2d93-3447-45e2-a9c1-022be38e1dc6"), Type = TextBlockType.Text, Text = "Your duskwalker heritage allows you to extend protection against negative energy to yourself or an ally in need. You gain resistance 5 to negative energy, and once per day, you can cast (spell: death ward) as a divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84350b06-d644-4f25-9ece-c9250a08b58a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
