using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("026f68e5-370d-4e50-a530-8c2a982f81b7");

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
            yield return new TextBlock { Id = Guid.Parse("592c1abb-7420-480d-9302-34419d9fd059"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("afc9f8d8-2b3b-470d-8a65-b16798108ff9"), Stats.Instances.Strength.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("8bb13bcd-8e35-4f2a-ba4b-0f9d3e8cad58"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("75c93ec5-62bf-4213-ae45-51f19b67e945"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("c3eec2f3-5f7c-4564-b8c3-8b99b4f25854"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f46760d4-3f0b-4bfc-abd3-91cf7484dea8"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("485f6644-eae0-4956-8756-22899e63eafa"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("109f5302-8814-4e23-8475-2c1e23ea69ee"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            //TODO: Add 2 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("624aae8f-dfde-4683-8123-232d4b2db75c"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("ad5959d2-8015-42e3-a206-5838252c2c51"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("ccee2ab7-1d8c-4f6e-a68a-02416ec80f0a"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("4882bcbc-14ed-4fb6-aaa0-e9df924fcd04"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("3c147e4b-9b51-469a-b578-5385a3950483"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("0e132b23-c967-4b86-a485-f59ba893e416"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("bab735bd-26d9-47a8-80db-718dabad45e0"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("1d810ff3-ddc6-4e85-8fbf-e5ee715daa56"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0514e458-3823-48ab-9d6c-db5809121c04"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 36
            };
        }
    }
}
