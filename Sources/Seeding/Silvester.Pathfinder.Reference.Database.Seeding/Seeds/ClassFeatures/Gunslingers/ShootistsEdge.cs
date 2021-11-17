using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class ShootistsEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("711257d6-6cc0-40eb-a463-1f545189eebd");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Shootist's Edge", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("69ae18d3-2447-4356-8241-75fe3d7a5565"), Type = TextBlockType.Text, Text = "You make shots others find impossible. Your proficiency rank for your gunslinger class DC increases to master. When using a ranged weapon in which you have master or greater proficiency, you ignore the penalty for attacking within the weapon's second and third range increments." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("f4318cf8-b074-4eab-afe1-d6ad5a95b2f7"), Proficiencies.Instances.Master.ID);
            builder.DisableRangedWeaponRangePenalty(Guid.Parse("f85ffeb5-327c-4c6c-845a-b5b1bfee3dc4"), RangeTier.Second);
            builder.DisableRangedWeaponRangePenalty(Guid.Parse("460844a0-811c-4201-bebd-b1fb46d4ac7a"), RangeTier.Third);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc0a7b7c-dc07-43f9-99bb-7733c93cae95"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
