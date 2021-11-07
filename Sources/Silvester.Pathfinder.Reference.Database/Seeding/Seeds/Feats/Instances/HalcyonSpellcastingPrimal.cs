using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpellcastingPrimal : Template
    {
        public static readonly Guid ID = Guid.Parse("bb347352-ebf7-4030-bc0c-5e6403aec544");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Spellcasting - Primal",
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
            yield return new TextBlock { Id = Guid.Parse("b2ea27fe-6b8d-4ee5-a0cf-f71d9404ce96"), Type = TextBlockType.Text, Text = "__Your halcyon spellcasting is primal.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2947af90-ddc0-4807-bb87-6572de34c813"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
