using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("c1a1c4d8-5b25-4dfe-9815-d7d4663ad771");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("657a93ea-9394-4972-b916-5983dfe27e12"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("abeb86f6-aee0-4337-90d7-6652b6ae7d67"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("9fdcbc7c-2d3c-4206-b269-610c37d39873"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("e57a89c6-c8d6-4e83-b55f-805ead9db403"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("16157e82-1304-4e11-b510-d704bb6dfc7a"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("0932044d-0e3f-4234-bb1f-9afd5e14cfdd"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("3b3c9a35-4388-4c89-bef9-b6a474c125ee"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("616325dd-c427-48f1-add3-e780d358a2ef"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("25303d4b-12e7-4b81-85c5-293f2d578c2e"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("f82a3f87-a84a-4251-ad63-1175951929df"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a915fad-09cc-4e75-bfe0-d3ddc7486cdd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
