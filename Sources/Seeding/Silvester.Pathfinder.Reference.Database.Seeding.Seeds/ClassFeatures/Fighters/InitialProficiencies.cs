using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("43b11fc3-88a3-46fd-9f71-c74b235eedcd");

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
            yield return new TextBlock { Id = Guid.Parse("7ae91535-0d98-4d28-adb1-3917662e948f"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("4e60f4ad-16db-403e-afb9-ac96e18245e8"), Stats.Instances.Strength.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("4d815450-8e42-4e92-a5ac-dc4b07f8e673"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("d0b46caf-8e16-464e-97f2-f7f4facd5737"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("5ecf2811-d351-4e74-ad65-3459fc83b811"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f15eda01-5412-4a50-8cfc-144f0da69ca2"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("ce2be8a9-85a1-41b5-b0c9-c25f60db6d2f"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.AddOr(Guid.Parse("d8884c85-29a7-4784-8d82-823c1c492294"), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse("8a965c96-ceec-4f54-bf7f-6326a2d3d813"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("658b6156-57fc-41da-8f48-d1bddcabfdb6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            });
            //TODO: Add 3 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("dae149db-1306-4f10-87a1-631270ffc5fa"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("77f78584-baa1-4fed-9656-123cb23fd5a6"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("d4122052-58c4-4876-a269-ca73d2733e16"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("51533007-d164-4144-83b3-3190e656ccc1"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("94155c61-8390-4322-866b-cc7a6164a5b2"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("0d91ba94-c014-41f7-9b03-518b4530a38c"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("6e6d2db7-9e54-44e3-8323-8f5710b94114"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("cc77a742-20a2-4c8f-8d1f-8850d4de559d"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("75b0f4ee-31b1-4d74-aec3-da6f315a0b57"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f86a8c67-7893-489a-b1bd-4d2d0efd5394"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
