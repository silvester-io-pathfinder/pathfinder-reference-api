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
        public static readonly Guid ID = Guid.Parse("1284d8a8-32b5-48e9-a274-3c94ebbb346e");

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
            yield return new TextBlock { Id = Guid.Parse("75ca2a98-fe0a-4430-b292-c0c999e07c38"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("b776c52a-a69c-4441-8be5-625f6d2fd8aa"), Stats.Instances.Charisma.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("1a71a6c3-d91a-47ea-9084-e656ab3c6295"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("d03b9606-9cda-438d-8bbc-8410acf3082f"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f0b41b8e-522b-40da-8e0b-6024b601e27a"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("1deceeb4-a6ad-49a8-b789-41c65ba0734b"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("93d28728-3026-4e9d-97bd-da7496ae9cfb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("75dda943-ee08-4024-a206-6214aeaa8d83"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            //TODO: Add 4 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("f88bac75-139b-4d30-897a-a70a65d61979"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("47209f3b-33cc-47a2-8d12-23dfd825126b"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Longsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("c8f9bd2e-9858-497c-9de9-57ab0cf2054e"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("eba35543-a7eb-4187-ae41-2c7c8ba45612"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("979bb1e9-7dc9-4f4f-92be-84cec1490d0b"), Proficiencies.Instances.Trained.ID, Items.RangedWeapons.Instances.Shortbow.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("c5f29f1b-40e8-457f-8edd-e9b794d2de51"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("1e5d0cb0-0528-4451-ab82-ba96d3be7623"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Whip.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("c3c5f976-0e7e-42a3-bfba-2a5a6c55df12"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("0c5b8cba-3888-43f3-90e6-e3d17a885fa6"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("bf1386e6-97fd-4d88-8bf8-2af1b7ad7be9"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("40384441-eca5-47fb-82d5-6458d03e1c54"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("2494e396-a996-4438-b147-ab394063ee2d"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15d6665c-3f28-44ea-8fa7-a2da65684118"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
            };
        }
    }
}
