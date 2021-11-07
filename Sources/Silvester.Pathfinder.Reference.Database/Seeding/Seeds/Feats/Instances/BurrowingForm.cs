using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BurrowingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("52810fbc-cb98-40c6-90bb-8dcfd8e1b7a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Burrowing Form",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9e01c87-b7d2-4ecb-bd13-9602b077ef29"), Type = TextBlockType.Text, Text = "Your eidolon can burrow through loose dirt. Your eidolon gains a burrow Speed of 15 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f78f2d1-5cb7-4b71-8a3f-f725683c951f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
