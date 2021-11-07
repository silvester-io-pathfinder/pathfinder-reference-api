using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpellcastingArcane : Template
    {
        public static readonly Guid ID = Guid.Parse("6d2ac865-e9ab-4030-ae85-84076ede08e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Spellcasting - Arcane",
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
            yield return new TextBlock { Id = Guid.Parse("69a4548e-75f5-47e9-8b59-d311ccc7a608"), Type = TextBlockType.Text, Text = "__Your halcyon spellcasting is arcane.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f800e102-97c4-4dad-94df-1867b0250b85"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
