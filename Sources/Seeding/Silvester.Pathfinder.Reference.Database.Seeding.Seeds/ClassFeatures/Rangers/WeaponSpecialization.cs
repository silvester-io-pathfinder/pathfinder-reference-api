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
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("468edd40-2d5b-468e-8436-49e50ba31366");

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
            yield return new TextBlock { Id = Guid.Parse("d69538dc-9a17-4f49-ad5d-698e8cc01807"), Type = TextBlockType.Text, Text = "You�ve learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you�re a master, and 4 damage if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("ab481bcf-f7b8-4365-948c-6dd9725e201f"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("3b9aa704-29c8-46dd-8e54-dcf37be53419"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("2fad7700-e354-4ea6-9fa5-1cdf828ffe95"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("8f04df64-0d2d-4961-a172-e6d56b435e9d"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("ebfe6e30-aab0-43e5-b083-f31b4bca2bcd"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("88656ce0-d7bb-435b-9092-ec1777ab8a70"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("9c6d5762-3715-434e-92a8-c64afd67e703"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("3272fbe0-59fe-4519-83be-86cd3874701a"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("0b5a9b6e-7746-4b07-97a5-3c7c95b312f3"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39167bc2-a73d-464b-8222-1f17dd055bf2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
