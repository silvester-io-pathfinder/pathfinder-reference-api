using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("28975ea9-4615-4483-b736-8a60fb773fa2");

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
            yield return new TextBlock { Id = Guid.Parse("804d010b-b2e8-4d68-b329-56266fdbb360"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability 
            builder.GainSpecificKeyAbilityOption(Guid.Parse("2c3a8420-7fbc-44ec-ba56-f83d78921ba9"), Stats.Instances.Strength.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("6d802f1a-b7ef-4b77-9137-f150d2c434f6"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("b3efa18d-131c-4f3f-ae19-fec1fec0a147"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("d4e3f71a-0413-4395-a542-73ed63c8686b"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("b4db3557-8273-4a47-95c9-85a04e1fe0ca"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("67fff6ab-0538-4746-8783-b8fd293247e1"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("9c61778b-f2ed-42a3-a202-76a5130e8fec"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("fccfca63-70a7-4978-aba2-0f1d3228c337"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            //TODO: Add 4 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("e3eff77f-66ee-448e-9b5c-82eee09d9d31"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("f8a79d51-a5c7-4ec1-931b-5843f2ccc3cd"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("96994155-94f2-489c-976c-c32d773dfaba"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("d251ee23-4007-4b0f-9783-814e054ce9c4"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("af4c3a5e-ea6a-4c9a-bf27-0964a1b11767"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("41200de3-10d4-4592-8ecd-9a253d18b6e9"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("e339fa89-f15f-4c5d-b6cf-65e9ff7feefe"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b4a3082-9aed-4410-be01-4396af0a9319"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
