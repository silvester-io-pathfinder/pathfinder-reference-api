using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CMArcaneSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("90cc0aa9-b11f-45e6-9d00-ee72313932e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "CM - Arcane Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("eb8faf01-cf5d-4356-85f7-56d6155a39c9"), Type = TextBlockType.Text, Text = "You’re trained in arcane spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add an arcane cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbd1112e-32bd-42c3-b75f-f400f966dfb0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
