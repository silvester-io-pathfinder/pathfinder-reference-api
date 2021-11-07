using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NantambuChimeRingerDedicationOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("1b9d8681-a1a1-486e-8537-2b77905e7609");

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
            yield return new TextBlock { Id = Guid.Parse("8dce85ea-e0ef-4ac8-aa98-be74b2a89b9a"), Type = TextBlockType.Text, Text = "You gain the ability to cast a single occult cantrip of your choice. If you weren&#39;t already, you become trained in occult spell DCs and spell attack rolls with Charisma as your spellcasting ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a421cedb-a70c-458a-8846-81d772790053"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
