using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NantambuChimeRingerDedicationOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("b482dc93-942a-47fd-ac52-27fbb4ddf2d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nantambu Chime-Ringer Dedication - Occult",
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
            yield return new TextBlock { Id = Guid.Parse("ea8f6907-5d79-42ed-b606-aaca359abe9c"), Type = TextBlockType.Text, Text = $"You gain the ability to cast a single occult cantrip of your choice. If you weren't already, you become trained in occult spell DCs and spell attack rolls with Charisma as your spellcasting ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b670c2c-a397-40bc-b20d-4ac315dedb9b"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
