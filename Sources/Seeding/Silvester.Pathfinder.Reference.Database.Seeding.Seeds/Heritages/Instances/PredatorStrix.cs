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
    public class PredatorStrix : Template
    {
        public static readonly Guid ID = Guid.Parse("854c31e2-ddaf-4f69-b274-fba26e0d8446");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Predator Strix"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2c179f0d-04ea-4d7a-9455-a9b07d7e7a93"), Type = TextBlockType.Text, Text = "You come from a line of strix with exceptionally broad wings and lengthy talons. You gain a talon melee unarmed attack that deals 1d4 slashing damage. Your talon attack is in the brawling group and has the agile, finesse, and unarmed traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Find a way to add traits.
            builder.GainSpecificUnarmedAttack(Guid.Parse("dc52ebd6-f0ae-409a-987a-8f72930b88a6"), UnarmedWeapons.Instances.Talon.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Slashing.ID, damage: "1d3");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad1bec7b-dc8b-43ea-b011-fa56dfc7c20f"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 135
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Strix.ID;
        }
    }
}
