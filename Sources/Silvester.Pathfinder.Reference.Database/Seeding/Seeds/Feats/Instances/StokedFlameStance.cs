using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StokedFlameStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e0f989e4-c65e-419e-9de9-4f3c840016a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stoked Flame Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat gains your choice of either the divine or occult trait, matching your ki spell tradition if possible.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("541e7523-9beb-4f93-9987-a6a15c9751ce"), Type = TextBlockType.Text, Text = "You enter a stance of fast, fiery movements. You can make flashing spark attacks that deal 1d8 slashing damage. They are in the brawling group and have the (trait: forceful), (trait: nonlethal), (trait: sweep), and (trait: unarmed) traits. If you have access to the flashing sparks’ critical specialization effect, you can take an alternate effect instead: if your critical (action: Strike) dealt damage, the target takes 1d6 persistent fire damage." };
            yield return new TextBlock { Id = Guid.Parse("2c5bf1e0-d097-484d-b23a-6a2e687382d3"), Type = TextBlockType.Text, Text = "While in Stoked Flame Stance, you gain a +5-foot status bonus to your Speed. If you have incredible movement, increase the benefit from incredible movement to a +15-foot status bonus plus 5 feet for every 4 levels beyond 3rd." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2302a2e4-25c0-4668-a7da-fca72969597a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
