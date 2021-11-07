using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NantambuChimeRingerDedicationArcane : Template
    {
        public static readonly Guid ID = Guid.Parse("e9d6f615-c19b-4871-8986-317dfebca173");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nantambu Chime-Ringer Dedication - Arcane",
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
            yield return new TextBlock { Id = Guid.Parse("92bb208d-f253-470a-ba96-b56af8783f84"), Type = TextBlockType.Text, Text = "You gain the ability to cast a single arcane cantrip of your choice. If you weren&#39;t already, you become trained in arcane spell DCs and spell attack rolls with Intelligence as your spellcasting ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dc15e36-1c4e-4d4d-9d7c-a62849e93cc2"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
