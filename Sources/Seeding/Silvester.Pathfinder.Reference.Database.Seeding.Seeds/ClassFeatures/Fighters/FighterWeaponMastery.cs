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
        public static readonly Guid ID = Guid.Parse("7ce53163-cb9c-4b85-85e3-bcdcdbc117ec");

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
            yield return new TextBlock { Id = Guid.Parse("9cd1b132-0dc8-4747-98fa-614bf3218edd"), Type = TextBlockType.Text, Text = "Hours spent training with your preferred weapons, learning and developing new combat techniques, have made you particularly effective with your weapons of choice. Choose one weapon group. Your proficiency rank increases to master with the simple weapons, martial weapons, and unarmed attacks in that group, and to expert with the advanced weapons in that group. You gain access to the critical specialization effects of all weapons and unarmed attacks for which you have master proficiency." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse("0f79e0a8-0e20-48a1-a3ab-9bc07b2211ef"), prerequisites => 
            {
                prerequisites.HaveSpecificLevel(Guid.Parse("c2631b26-2f24-4591-a889-7e04fbc133b4"), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
            });

            builder.GainAnyWeaponGroupProficiency(Guid.Parse("bb423a7f-0776-4c0a-9a26-792c372afaad"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("8375736f-06e6-4d0d-acae-a90168e5e403"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("41a0d94c-764f-4760-82d0-6737fd81593f"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("39e92790-de99-47ea-bfbc-e95957d28140"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainAnyWeaponCategorySpecialization(Guid.Parse("cb9fab2b-ec51-42d9-9341-9524cab98ae8"))
                .AddPrerequisites(Guid.Parse("c4644283-8bf4-49ff-9a8a-7f980dab6a6e"), prerequisites => 
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("6b52a89c-18a9-4084-b430-1b06487cffb2"), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Master.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0de64dd-ef1a-4aeb-afa4-330713ec9372"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
