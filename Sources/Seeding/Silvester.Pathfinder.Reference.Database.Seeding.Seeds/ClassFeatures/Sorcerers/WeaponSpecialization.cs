using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("fc0d728f-71b8-48e8-8997-327d31f63d80");

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
            yield return new TextBlock { Id = Guid.Parse("c70f91d6-d61f-416d-80f4-6a238ef09237"), Type = TextBlockType.Text, Text = "You've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you're a master and 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("62a8882b-7ab3-463a-8a5d-20aafac869ea"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("56a6ce4d-1016-416a-95e0-f83c112d556b"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("2f1b5368-4760-465c-9628-f6c614cf2777"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("a54e0667-d52f-496d-b662-38c2d7da8778"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("719b9c77-3d13-41a1-85ec-740a4071f175"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("8722e624-597c-47ab-8371-1d27d0b772b5"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("9655f0e5-60cf-45fd-81d8-4bb2818ced80"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("be061aaa-ee9f-4a73-9113-1a0565cf9bc8"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("0785a62c-5f2f-4561-b326-e88e3fcb3d5d"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e22a33b-7227-4bef-ab8e-b70e00228082"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
