using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CMOccultSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("f9ffc3fe-0e38-4359-9b00-13cd4d7db615");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "CM - Occult Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("f0a53a7e-0204-4cef-820a-428a91170233"), Type = TextBlockType.Text, Text = "You’re trained in occult spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add an occult cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb4032f4-13e1-4dea-928e-e68572b2b17c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
