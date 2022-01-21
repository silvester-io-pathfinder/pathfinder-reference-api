using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("0355f799-6cec-4f1f-8e76-5ceb710ce26d");

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
            yield return new TextBlock { Id = Guid.Parse("b02129f1-a5fe-485f-b515-c81aa93f92e0"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you�re an expert, 6 if you�re a master, and 8 if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("bc5b741d-a924-4e8b-aedf-88118bbd5009"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("34320f7c-9751-45c7-a5c6-06106d3de3a8"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("47735a2f-9ac5-4846-aedb-146ed1f3ecc4"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("17761f7c-8d3c-471c-abf9-851551edd8f7"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("1f9af5fc-e2c9-4a38-8218-fd52cb9fe242"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("675836b3-86a8-4841-a48c-02a239aff122"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("6e87bdfa-f587-4bc9-89fa-e799460926fb"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("4b91236c-d453-4ab5-8bc3-a4acd9ea8819"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("4419daba-fce4-4559-9284-0edb9c47dd22"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a96eb5b2-6fc7-4620-bdfd-17f8db2ee27e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
