using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3bacf1b4-493b-498a-9bab-2da7577d395b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5edb5728-41c7-42ba-bf3b-03ea9cb7f040"), Type = TextBlockType.Text, Text = "Your eidolon channels its anger into a furious attack. It makes a melee (action: Strike). This counts as two attacks when calculating your multiple attack penalty. If this (action: Strike) hits, your eidolon deals an extra die of weapon damage and gains a +1 circumstance bonus to the damage roll." };
            yield return new TextBlock { Id = Guid.Parse("7d2cdfcc-1edb-4fbc-a4f2-7d004b8fc173"), Type = TextBlockType.Text, Text = "If you’re at least 10th level, increase this to two extra dice with a +2 circumstance bonus, and if you’re at least 18th level, increase it to three extra dice with a +3 circumstance bonus." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ec456f3-8136-44bb-9b11-f8c8031cef53"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
