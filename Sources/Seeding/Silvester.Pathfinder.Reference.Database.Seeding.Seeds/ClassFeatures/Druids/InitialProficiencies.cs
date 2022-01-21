using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("f03e363e-ef1f-47ba-8e17-a6b6e2944ebf");

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
            yield return new TextBlock { Id = Guid.Parse("a16c0e70-6242-4203-8d0d-ee51bb7876a1"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("c16d9e45-61a1-4f4b-b1e2-9890bb88ebc6"), Stats.Instances.Wisdom.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("6329809f-7ebd-48d8-b41a-6146c0e4ea7d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("a1edd815-ffe2-45bb-aa1a-944396187951"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("5931026e-30de-4b73-9e85-6cb0e04782e9"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f94067e5-7dfb-46a1-a313-e4da39b35789"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("a6a8c1d3-84da-4486-bb37-83fce5bf2246"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            //TODO: Add 2 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("05305d52-2b14-4c83-9cde-21d76b1b6235"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("b4b217bd-190e-4e8e-9e54-ab39492815e6"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("170ef353-011b-4f13-b189-1e5d3a69e7ef"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("1e92a8e0-8b91-497f-9746-515f523aa653"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("37468568-9402-4fb9-88b7-ac38a792a814"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("a73ff328-89e2-4a61-996d-6a850976a0a6"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("9a6fbea5-6dc9-4728-886a-d05a186a0070"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c4090a9-3cfd-4cf6-8464-d2439dedb0c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 130
            };
        }
    }
}
