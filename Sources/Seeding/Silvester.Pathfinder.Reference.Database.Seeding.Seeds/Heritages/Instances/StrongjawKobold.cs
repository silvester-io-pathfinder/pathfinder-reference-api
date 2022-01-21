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
    public class StrongjawKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("f071d98d-7aba-45f5-8870-ecfdf7071cbb");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Strongjaw Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("eda0f0c7-eb79-4149-a157-11beadd16058"), Type = TextBlockType.Text, Text = "Your bloodline is noted for their powerful jaws and sharp teeth. You gain a jaws unarmed attack that deals 1d6 piercing damage. Your jaws are in the brawling group and have the finesse and unarmed traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificUnarmedAttack(Guid.Parse("770ef344-87ee-4a94-a050-c0e313dbbb08"), UnarmedWeapons.Instances.Jaws.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Piercing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f388b2e1-5167-4b95-9395-b258929efa7d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 14
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
