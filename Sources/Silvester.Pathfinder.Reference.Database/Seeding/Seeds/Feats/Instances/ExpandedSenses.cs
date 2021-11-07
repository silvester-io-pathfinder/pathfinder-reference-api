using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpandedSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("3d040a9b-7687-4a2b-bd8d-4daa026d869b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expanded Senses",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d30dd5e4-ada6-4cbc-b097-8c4e3cffb682"), Type = TextBlockType.Text, Text = "Your eidolon evolves more acute senses. Your eidolon gains low-light vision and darkvision, as well as scent as an imprecise sense with a range of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("871cf393-1157-46ed-af4e-73d405b2846f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
