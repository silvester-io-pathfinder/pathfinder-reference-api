using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("34e40ee4-b0a2-44d6-9a0a-cf14591c8803");

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
            yield return new TextBlock { Id = Guid.Parse("c0d4646f-fc2d-4807-8b4d-a9fd502dea60"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("87417016-eb98-402e-8683-6c7b50f013f9"), Stats.Instances.Strength.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("a64794f1-973d-46dd-9dfb-f93e39cc6681"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("f6027066-feb8-428d-bb1c-f7e66663ae2c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("4db730b3-e0b1-4012-8c4d-a34c870cb38d"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("27b1585b-a757-49d6-809c-411d566453b3"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("e7693f85-1100-458d-bcb9-917dd5e965e0"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            //TODO: Add 4 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("a7ab65e1-ca12-44c2-b250-161e361d7e29"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("3df2086d-d109-4940-892c-ee782c42154f"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("91f09596-fc17-4e8c-826e-3765220a484d"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("ba4e77a2-9d4d-4e43-8d8e-b968609d829c"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad07e911-a7f4-4f41-bd5a-fab5102e53b2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
