using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class GreaterEidolonSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Eidolon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's damage from weapon specialization increases to 4 with unarmed attacks in which it's an expert, 6 if it's a master, and 8 if it's legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse(""), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse(""), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse(""), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse(""), ModifierType.Add, modifier: 4)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
