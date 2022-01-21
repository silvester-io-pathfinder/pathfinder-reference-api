using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("5bc9e1e5-2c66-49b0-a186-d9cdb4119587");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6f080f22-888d-45c8-a0de-f43cbefbaf8f"), Type = TextBlockType.Text, Text = "You've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you're a master and 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("b3177754-045a-4493-9839-55ebf047d3c6"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("bdae857c-7de7-410d-b2c9-f682be58dc32"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("2598f0de-e488-4811-ae32-22b1f56873c5"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("e3d266e5-3366-4c13-8e36-0ba4b0a5ff48"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("975985c0-2f27-4244-891a-5b9cc86331a8"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("98460d2e-5938-4e0a-9156-1816a6d46c48"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("eac4211a-1fcf-4bfb-a88e-02d9e3ddc96a"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("c959ac52-5024-4d97-9737-6ac890f3288b"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("bdccf95a-7211-4349-8343-51505fe45c84"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d48e6b9b-032b-4fa3-8425-586b8dc14c11"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
