using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwoWeaponFusillade : Template
    {
        public static readonly Guid ID = Guid.Parse("916f0ac7-93e0-4986-9e24-f75e2201c52e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Two-Weapon Fusillade",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6fa9fb79-d42c-4181-96d3-b41d01be34c5"), Type = TextBlockType.Text, Text = "You attack with both your weapons in a furious barrage. (action: Strike) twice, once with each weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c88793f-8b7e-406a-ae4f-55ef98126001"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
