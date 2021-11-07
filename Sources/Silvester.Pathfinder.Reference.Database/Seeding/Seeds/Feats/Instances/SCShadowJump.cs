using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SCShadowJump : Template
    {
        public static readonly Guid ID = Guid.Parse("651725c4-48de-4a43-bc0c-4700aa8aca1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "SC - Shadow Jump",
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
            yield return new TextBlock { Id = Guid.Parse("c39eaa19-8151-4189-ae9c-14b4eda436e3"), Type = TextBlockType.Text, Text = "You learn the (spell: shadow jump) shadowdancer focus spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11ac031c-c0ae-49f9-8a0d-c8e6f69d5a4f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
