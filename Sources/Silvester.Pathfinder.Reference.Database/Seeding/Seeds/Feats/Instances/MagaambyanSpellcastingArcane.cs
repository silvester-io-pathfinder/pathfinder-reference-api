using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagaambyanSpellcastingArcane : Template
    {
        public static readonly Guid ID = Guid.Parse("9354f387-c638-4d82-aac4-48ceff7c9c82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magaambyan Spellcasting - Arcane",
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
            yield return new TextBlock { Id = Guid.Parse("62119490-bdf4-4836-b79f-464f3079b40e"), Type = TextBlockType.Text, Text = "__Your halcyon spellcasting is arcane.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6711ab32-4d76-456e-b50a-9269b278cde5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
