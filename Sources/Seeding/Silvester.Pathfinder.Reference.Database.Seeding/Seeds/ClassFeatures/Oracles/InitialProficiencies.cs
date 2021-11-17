using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("a01f9d80-67f3-43e5-ada9-48742327f0be");

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
            yield return new TextBlock { Id = Guid.Parse("4e016ddd-b3c6-4354-a6f7-d2275cdcc29d"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability 
            builder.GainSpecificKeyAbilityOption(Guid.Parse("ac476d93-9d7b-4bf9-a805-de4e194153a7"), Stats.Instances.Charisma.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("d795db65-a9da-4208-9121-9105fae9d7b8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("33b5d765-f90b-46a2-bd5d-0e80a8491643"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("882f2885-e2ba-4f04-b72a-26189e0b9bdb"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("3ba6f82b-a47c-495b-abe4-bb272b29f4e6"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("07c6cafd-c7b9-481c-bd64-8ed96268e349"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            //TODO: Add 3 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("1d4777b5-4d71-4f4d-ae6c-022c1031adeb"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("a14a0a9d-02ec-43e8-a86b-7cc50f904c88"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("01a1930b-3829-48f9-a9f8-4915321cab9b"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("406978e7-36bd-4bab-8309-fcdfbae413c1"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("8b9c5271-d91e-4294-9dde-ccbcc0a227c2"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("126c9ccd-7298-42fa-86cb-d45b55ca79bc"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d1a1ffb-de93-46bd-b509-7fc8b74bca66"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 68
            };
        }
    }
}
