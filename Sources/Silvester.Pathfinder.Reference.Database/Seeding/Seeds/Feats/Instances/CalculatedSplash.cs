using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CalculatedSplash : Template
    {
        public static readonly Guid ID = Guid.Parse("0029b1a1-1314-4dbb-beae-cf896210b3c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Calculated Splash",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48f251d2-2c59-4829-a846-942ea2e89021"), Type = TextBlockType.Text, Text = "You have calculated all the angles to maximize a bomb’s splash. When you throw an alchemical bomb with the (trait: splash) trait, you can cause the bomb to deal splash damage equal to your Intelligence modifier (minimum 0) instead of the normal amount." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30c807d1-c611-4852-90d5-390aedf8c362"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
