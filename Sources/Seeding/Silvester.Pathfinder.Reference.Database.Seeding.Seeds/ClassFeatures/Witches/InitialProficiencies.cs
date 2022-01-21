using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("a9bcc9e7-43b4-484c-8b19-8f5ffde19610");

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
            yield return new TextBlock { Id = Guid.Parse("f4544965-20f1-492e-adf3-2dfe0506a4c8"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("7a1d83a1-28b4-4b38-930d-024636cd9f2e"), Stats.Instances.Intelligence.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("5431f0ee-18ca-4e05-ad1b-4cfeab8d4a5d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("d0304d9c-a681-4b0a-99a2-f2692a5c36c5"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("fdf0c351-47df-449f-98a1-b48955fb5f28"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("3b04e358-dab9-4f7c-8799-ae786da4eaf1"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            //TODO: Add 3 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("a56a5580-75ba-48ed-8e40-7f01ef72cf4e"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("7b3f35fb-e923-4c5d-9836-ad7bfbb836b7"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("44553530-e4a6-42ad-ab80-b8521b31e69f"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("d52762e6-ef82-4cb2-ac46-09b4ed5358fe"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("1d1e99be-3d60-48fb-b23b-986a45658671"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9af5703-9637-4ed7-9adc-bd01ce7ee0f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 96
            };
        }
    }
}
