using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("b34cd5f8-56a4-4b96-bfb0-ac501a761043");

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
            yield return new TextBlock { Id = Guid.Parse("cdadbc81-7d2a-4f24-9c24-6f2dc1a14d81"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("cb9680de-7dec-4d99-aa83-f0ad15b468cd"), Stats.Instances.Intelligence.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("ef6f6304-e592-4179-8cf2-4d42a332d20e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("0dd6df70-572e-4ee5-ac18-480cfa7df2f8"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("813a2b64-05a6-4b74-b26d-6a629d3908ca"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("174243fb-1012-4574-88f7-3dbfb40a44d3"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("bdcb53a5-c501-4e18-beb2-79b4694a0c52"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            //TODO: Add 3 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("a1a678af-6aa2-47aa-bfdb-987eda0849f4"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("e4f297fc-0baf-4c68-9924-1b11468209bc"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.AlchemicalBombs.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("6a20a390-10f7-45bf-8bd4-fbe9e125c0f6"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("40bf7720-9c43-446d-8635-a8bc9620dbec"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("c4be3582-60d2-483e-8382-eb5028469c8d"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("9d0faa14-c39e-457b-b0ac-49f34041ca08"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("0d048830-2a81-48e7-ac61-5c279adfc3a5"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d3e86bc-6b7a-4487-9d8a-c35150856f92"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 72
            };
        }
    }
}
