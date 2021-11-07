using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SDShadowJump : Template
    {
        public static readonly Guid ID = Guid.Parse("4b2cdeb9-932e-4350-a840-b0cf0f65fb93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "SD - Shadow Jump",
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
            yield return new TextBlock { Id = Guid.Parse("d3b4753b-f50c-4ab4-96a3-0beaa0b3fc57"), Type = TextBlockType.Text, Text = "You learn the (spell: shadow jump) shadowdancer focus spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("187ce68a-c30d-409e-94bf-148a4bf907d6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
