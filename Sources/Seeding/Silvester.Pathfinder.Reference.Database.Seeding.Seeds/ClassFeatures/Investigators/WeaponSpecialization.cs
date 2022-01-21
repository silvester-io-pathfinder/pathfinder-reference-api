using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("97da9770-6aff-4801-bf49-a317e46fd803");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("df1a46a6-6d02-4319-85bb-6d23e0a05046"), Type = TextBlockType.Text, Text = "You�ve learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you�re a master, and 4 damage if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("f0a0a0ef-fde2-40bc-a358-5aa275c8b0cb"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("0fd92b88-8157-482d-8d2c-9aa8c6b69310"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("c6bee49b-0f62-4353-9ec6-2c4f0e373324"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("a25a87f5-64b3-4cca-8dc2-ff85c45e82bb"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("3db46e58-5897-4e29-aa51-3f4d9de3d822"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("92f9f25b-4a33-4c14-8a22-b29bad8d7a22"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("f0a0bdfc-df19-42ff-a7f3-cd08950633c7"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("e9eb8610-642b-4554-9300-565eb79fafc6"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("1378b05e-cb1f-4407-bcb8-b435588270e9"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f236d86-4f42-4511-925a-6dc035144e09"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
