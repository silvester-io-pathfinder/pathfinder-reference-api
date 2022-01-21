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
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("85ca974c-a52f-49b4-ae5c-bc1c124311b9");

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
            yield return new TextBlock { Id = Guid.Parse("fcefdfae-b2c6-4538-a031-048f860dc989"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you�re an expert, 6 if you�re a master, and 8 if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("08839ad3-70df-42d1-9c24-2b5e788478fd"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("3ecb1b56-3502-4447-85b0-0836632f5d9d"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("b9f57ece-ec24-4fc2-9c9d-71e326706187"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("83140fdb-e61d-4c65-8c92-62538d2b187a"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("480b8eac-e971-4110-bd6d-f478a6dd0f72"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("17a92a7f-1db0-4874-adc2-0198a0bbbabc"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("e8f6c0eb-6519-48da-8680-ee013bb8ba4a"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("d9a40227-0f30-43c1-ae18-4f4b0279ff04"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("b92ee117-5451-4612-8687-ffbe23076dc7"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ca09633-7b71-48dc-820a-ecc2239f94ce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
