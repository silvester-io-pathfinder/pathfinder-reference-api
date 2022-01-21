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
    public class TalonedTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("de9d8b5e-e687-4060-87fc-421ff21aed91");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Taloned Tengu"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("28b13646-d786-4e70-87b4-bb03e0785fee"), Type = TextBlockType.Text, Text = "Your talons are every bit as sharp and strong as your beak. You gain a talons unarmed attack that deals 1d4 slashing damage. Your talons are in the brawling group and have the agile, finesse, unarmed, and versatile piercing traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add the traits.
            builder.GainSpecificUnarmedAttack(Guid.Parse("43c19b08-c6f1-4907-96ec-d2864d7a47d2"), UnarmedWeapons.Instances.Beak.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Slashing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d94bccc4-bf73-44ae-b12f-422be92d6f78"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 26
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Tengu.ID;
        }
    }
}
