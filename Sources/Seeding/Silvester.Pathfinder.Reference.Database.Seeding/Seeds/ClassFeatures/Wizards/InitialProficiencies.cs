using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("9196e29f-d947-4c14-a8b2-f6044ac0771c");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Initial Proficiencies", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b837fda9-fac1-4e67-8bd7-fc05225ab4d2"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("3f558241-6b8f-47d0-86e4-fec26d78e85f"), Stats.Instances.Intelligence.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("dcebc686-8b78-4989-ba98-5a46aa2551dc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("53cf685d-cd77-44c1-ac94-7a40bede3305"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("95b037a2-781f-44ba-a93d-dbbf61ab3298"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("4c854ff5-42c9-47eb-b7c7-c71b7f100c06"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("fea3f16a-f84c-4e53-a447-b0d25e1b9c38"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            //TODO: Add 2 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("a236e6db-64cc-45c8-b42f-841a9fc39dea"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Club.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("5e951a01-cc06-4fc1-a230-0b97982eeb29"), Proficiencies.Instances.Trained.ID, RangedWeapons.Instances.Crossbow.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("8ba0a861-aae7-4b8b-a4e8-08f720767f71"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Dagger.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("08a2a446-3fd8-4fa2-a0e6-fd31af4da4bf"), Proficiencies.Instances.Trained.ID, RangedWeapons.Instances.HeavyCrossbow.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("fc6bdf6c-4edc-4ba0-9493-2f88f176f4bb"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Staff.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("9948450c-0b3b-44b5-ac06-7c9bcfe39676"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("aaf18755-e8a4-46c4-a077-1d8b6737fa07"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("e16552c8-31ec-413e-8568-98fdb95c371b"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("731a04de-1e1d-4055-8f7a-184d2b3d8ff5"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab0f2faa-65da-45c4-8fa7-3abf9a7e5d83"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 204
            };
        }
    }
}
