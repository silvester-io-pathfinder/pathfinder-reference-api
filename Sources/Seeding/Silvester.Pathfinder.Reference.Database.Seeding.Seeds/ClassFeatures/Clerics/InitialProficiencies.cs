using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("46d05cbe-6585-41e1-a9b9-6778b08584c9");

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
            yield return new TextBlock { Id = Guid.Parse("2f59aa39-f4d7-403a-90d5-31149f5dd2d6"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("c324bd50-3b91-49b0-912c-842c933d3108"), Stats.Instances.Wisdom.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("3d816c83-5a14-4b56-8110-62c8ff6df4d3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("6060557b-df3a-474a-971b-06bbdf9dc55e"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("a482bc5c-90b9-4e17-ad99-6f0935288b12"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("34d99ba7-7577-4bf2-8dfb-1cc261ae649c"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("a94add56-d3f7-4008-96b8-e3457a3945e6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            //TODO: Add 2 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("4347b3d6-6a18-4d2c-af81-631a8f375f98"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("fa07f738-6bcb-4c2c-844a-7a482318ccec"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("ef98ba6c-1375-46bf-b954-fd5026d8e513"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("90d316ef-e99b-44ea-9ed5-448c4864be4e"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("2c7e10eb-2719-4c10-abec-a76521b82505"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64195e87-438c-4048-bd0c-1d4cda9e9d20"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 118
            };
        }
    }
}
