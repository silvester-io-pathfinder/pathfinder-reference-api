using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class FighterWeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Fighter Weapon Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Hours spent training with your preferred weapons, learning and developing new combat techniques, have made you particularly effective with your weapons of choice. Choose one weapon group. Your proficiency rank increases to master with the simple weapons, martial weapons, and unarmed attacks in that group, and to expert with the advanced weapons in that group. You gain access to the critical specialization effects of all weapons and unarmed attacks for which you have master proficiency." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse(""), prerequisites => 
            {
                prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
            });

            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainAnyWeaponCategorySpecialization(Guid.Parse(""))
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Master.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
