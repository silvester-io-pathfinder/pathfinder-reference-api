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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The chitin on your hands forms powerful claws that allow you to defend yourself. You gain a claw unarmed attack that deals 1d6 slashing damage. Your claws are in the brawling group and have the agile, finesse, and unarmed traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add traits somehow.
            builder.GainSpecificUnarmedAttack(Guid.Parse(""), UnarmedWeapons.Instances.Claws.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Slashing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
