using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StokedFlameStance : Template
    {
        public static readonly Guid ID = Guid.Parse("44afc16a-7e53-432a-be1a-4a500106534c");

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
            yield return new TextBlock { Id = Guid.Parse("3642c20b-0d2b-4d79-89a1-d2e5c2fab170"), Type = TextBlockType.Text, Text = "You enter a stance of fast, fiery movements. You can make flashing spark attacks that deal 1d8 slashing damage. They are in the brawling group and have the (trait: forceful), (trait: nonlethal), (trait: sweep), and (trait: unarmed) traits. If you have access to the flashing sparks’ critical specialization effect, you can take an alternate effect instead: if your critical (action: Strike) dealt damage, the target takes 1d6 persistent fire damage." };
            yield return new TextBlock { Id = Guid.Parse("1ee8b6d9-656c-4522-a71b-6bca3e730a1f"), Type = TextBlockType.Text, Text = "While in Stoked Flame Stance, you gain a +5-foot status bonus to your Speed. If you have incredible movement, increase the benefit from incredible movement to a +15-foot status bonus plus 5 feet for every 4 levels beyond 3rd." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("651f54d7-1cb3-4a34-b9a9-051fa000270a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
