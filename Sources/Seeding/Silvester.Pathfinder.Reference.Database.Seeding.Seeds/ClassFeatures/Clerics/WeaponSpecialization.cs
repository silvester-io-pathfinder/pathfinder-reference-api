using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("2c45c94f-83f3-48e9-b23c-fddd9ec89ded");

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
            yield return new TextBlock { Id = Guid.Parse("e220f4dc-f966-4597-8212-5e4d6672d68c"), Type = TextBlockType.Text, Text = "you've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you're a master, and to 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("f839e8e9-499b-4d9b-969e-9f1087c5bc2d"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("034c6164-aec3-4a57-b332-9105ad78daeb"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a01540ba-2487-4745-bbe3-56ff6412990e"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("a7b41f7d-6ac3-4146-a539-3c9927a5587f"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("95f4233b-ebab-4750-90e0-092878de78dd"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("4f80727a-a0b6-4d5c-a20a-4706b403ad43"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("8054afce-513a-4880-8579-4f7037d34db6"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("f88c718f-85a3-47f5-9990-9c128838e3f5"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("cb3cc70c-5baf-40bc-8252-45fc4647f92c"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("231dcc6e-0374-4897-bda0-310245c07eea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 121
            };
        }
    }
}
