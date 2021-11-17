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
    public class ViciousGoloma : Template
    {
        public static readonly Guid ID = Guid.Parse("df9dc67f-e9a5-4fb8-8349-b3e9e26265f2");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Vicious Goloma"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8d318492-282b-41f0-ba21-263620d0dce7"), Type = TextBlockType.Text, Text = "The chitin on your hands forms powerful claws that allow you to defend yourself. You gain a claw unarmed attack that deals 1d6 slashing damage. Your claws are in the brawling group and have the agile, finesse, and unarmed traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add traits somehow.
            builder.GainSpecificUnarmedAttack(Guid.Parse("354113cc-a9ca-4ba4-b3e6-50cf9cf5c4aa"), UnarmedWeapons.Instances.Claws.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Slashing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3deeda2-3462-46e3-a551-4dd58b712e33"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 115
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Goloma.ID;
        }
    }
}
