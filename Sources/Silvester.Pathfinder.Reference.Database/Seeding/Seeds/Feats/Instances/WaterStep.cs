using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaterStep : Template
    {
        public static readonly Guid ID = Guid.Parse("52fbaf20-2868-4fed-abb3-fa587ea93bc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Water Step",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b2287e5-7051-43f3-af3b-f8400ffaedc8"), Type = TextBlockType.Text, Text = "You can (action: Stride) across liquid and surfaces that don’t support your weight. This benefit lasts only during your movement. If you end your movement on a surface that can’t support you, you fall in or it collapses as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b482d15-ff68-45d0-ac53-8063f506fe43"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
