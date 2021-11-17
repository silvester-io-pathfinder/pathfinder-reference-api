using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("62f46031-f098-4644-a1c5-22835c3031b7");

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
            yield return new TextBlock { Id = Guid.Parse("c82d1452-0768-4a8b-9b0c-bc1c7d78c893"), Type = TextBlockType.Text, Text = "You've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you're a master and 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("81421875-9e13-4d83-a105-1c08b750ddc5"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("2fd100a5-5a5f-4e8f-8d04-d31b1274ecd0"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("e087ef2c-a2f2-4569-b2c8-9730d0ae9faf"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("fb88b753-93a0-4eb3-9cfc-35af93d3e2a1"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("179e57be-b3da-4630-8924-29d627ea731e"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("bea7da4c-e861-4221-b1ff-2ead3dc30b66"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("bfa34f57-568b-4832-801d-468adeb53319"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("69ad4ba0-c20f-4d17-886a-adf2bf867b5b"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("e528d520-8471-42e8-81be-4862c23f03b1"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f465255-bdf7-40fc-8b2b-730fca3ac9fb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
