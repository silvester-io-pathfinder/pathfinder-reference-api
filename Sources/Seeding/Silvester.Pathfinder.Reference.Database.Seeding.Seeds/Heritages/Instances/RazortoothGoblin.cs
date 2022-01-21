using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RazortoothGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("14a46d8b-148c-4671-90ec-622b746f75e0");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Razortooth Goblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e2b0f9c4-68d2-4151-98d8-3afa1a1d3ae2"), Type = TextBlockType.Text, Text = "Your family's teeth are formidable weapons. You gain a jaws unarmed attack that deals 1d6 piercing damage. Your jaws are in the brawling group and have the finesse and unarmed traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificUnarmedAttack(Guid.Parse("f6007d7e-c8a1-417d-921f-1ea9a0b99e65"), UnarmedWeapons.Instances.Jaws.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Piercing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("148a9c54-614e-458d-acbe-5d1f28dac3c6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 48
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Goblin.ID;
        }
    }
}
