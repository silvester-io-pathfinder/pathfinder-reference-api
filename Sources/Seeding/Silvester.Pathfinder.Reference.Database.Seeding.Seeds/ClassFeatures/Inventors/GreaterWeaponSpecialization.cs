using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("daa490b9-d7cd-4005-ac42-e443a5813005");

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
            yield return new TextBlock { Id = Guid.Parse("0a37c1ec-65cc-46a0-8103-d4ceb9cd7d0b"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("e587df81-6747-43f9-802b-2fc11056f256"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("7fc10162-6692-4a6c-92dc-16a213b1f8cd"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("25cd5635-1358-4c75-a136-1b722697a9c0"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("b7c95af5-9151-4167-b8f8-fe3725d25778"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("255c16fa-2873-403c-8646-d087a3639ce3"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("ae85e5af-7a20-4e4f-a5c0-0b4d43f45e79"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("57dac360-9b88-4a70-a81c-4f30d3ae8572"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("7570d06a-393c-4633-a87e-6bdd7eeaf934"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("4814fe77-a673-454b-9ed4-4ae96c5cef3d"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4974f3c3-3c52-45e6-94d0-c0b7c7b24a98"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 22
            };
        }
    }
}
