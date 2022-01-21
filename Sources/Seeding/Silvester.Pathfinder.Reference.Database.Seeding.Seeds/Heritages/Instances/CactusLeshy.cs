using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class CactusLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("e63c920b-1170-4d85-bb12-7540cd1bb61c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Cactus Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2f2097c8-c2f2-4d88-b0fa-5d87f9b767e7"), Type = TextBlockType.Text, Text = "Spines cover your body. You gain a spine unarmed attack that deals 1d6 piercing damage. Your spines are in the brawling group and have the finesse and unarmed traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificUnarmedAttack(Guid.Parse("0ca5939e-45c7-4fe8-ac91-5611b9e354b8"), UnarmedWeapons.Instances.Spine.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Piercing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf8789e8-191e-4c8f-98be-a00542d40fa9"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 41
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
