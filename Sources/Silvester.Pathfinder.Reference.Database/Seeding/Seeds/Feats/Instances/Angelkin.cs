using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Angelkin : Template
    {
        public static readonly Guid ID = Guid.Parse("028adbec-297a-46cc-a25c-9905e453935b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Angelkin",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d28ee10f-f533-42b0-af57-39314fbbcdc7"), Type = TextBlockType.Text, Text = "You descend from an angel – a winged messenger from Nirvana or one of the other celestial realms – which gives you a knack for cultures and languages. You gain the trained proficiency rank in Society. If you would automatically become trained in Society (from your background or class, for example), you instead become trained in a skill of your choice. You know the (language: Celestial) language, and you gain the (feat: Multilingual) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68ea4eed-11d5-4ac5-8b67-7e6c7bfbdbbc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
