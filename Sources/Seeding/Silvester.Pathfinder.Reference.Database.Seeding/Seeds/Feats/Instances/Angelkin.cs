using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Angelkin : Template
    {
        public static readonly Guid ID = Guid.Parse("2e795a4c-15b7-45f3-8c10-51040cbb0a57");

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
            yield return new TextBlock { Id = Guid.Parse("de418508-0a8c-41c7-b70e-55ec203e0205"), Type = TextBlockType.Text, Text = "You descend from an angel – a winged messenger from Nirvana or one of the other celestial realms – which gives you a knack for cultures and languages. You gain the trained proficiency rank in Society. If you would automatically become trained in Society (from your background or class, for example), you instead become trained in a skill of your choice. You know the (language: Celestial) language, and you gain the (feat: Multilingual) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c65caf2-6b7e-4802-b17b-41799139bf53"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
