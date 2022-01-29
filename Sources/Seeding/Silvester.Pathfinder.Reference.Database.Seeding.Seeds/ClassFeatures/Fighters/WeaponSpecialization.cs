using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("28e3d309-fa66-4b12-8841-acbe8359669d");

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
            yield return new TextBlock { Id = Guid.Parse("417962c6-59d1-4acc-a6ef-6f95ea980165"), Type = TextBlockType.Text, Text = "you've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you're a master, and 4 damage if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("19495518-a4e8-46de-a6fe-3731866de8ba"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("472101a1-f79e-49db-946c-20fba53c86f2"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a16e7eee-1380-4231-8e0b-137d2285b56b"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("f2888244-d516-41cf-ab2c-6a42b1e68df1"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("749d64cb-5191-45c7-92b5-f50b39a44ba8"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a053e9f7-01c7-4148-855c-979546784c63"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("58bb7157-d46e-40fa-80a3-c43642b4ff0b"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("14b9ca19-e401-4d18-85c3-12b6459fa2cc"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("36a89ad0-c0fa-48bb-a94a-cc278d1fb273"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c6e4cf5-b994-49be-aaa4-1db4dd9fa648"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
