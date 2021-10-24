using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class WizardWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11, 
                Name = "Wizard Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Through a combination of magic and training, you’ve learned how to wield wizard weapons more effectively. You gain expert proficiency in the club, crossbow, dagger, heavy crossbow, staff, and unarmed attacks." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Club.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Dagger.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Staff.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, RangedWeapons.Instances.Crossbow.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, RangedWeapons.Instances.HeavyCrossbow.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
