using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Charisma.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            //TODO: Add 4 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Longsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, RangedWeapons.Instances.Shortbow.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.Whip.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
            };
        }
    }
}
