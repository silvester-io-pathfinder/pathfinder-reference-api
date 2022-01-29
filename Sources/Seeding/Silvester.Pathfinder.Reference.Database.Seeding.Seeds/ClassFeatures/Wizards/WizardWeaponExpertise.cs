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
        public static readonly Guid ID = Guid.Parse("dc2334b6-cea3-4eaf-84f3-71f028e87741");

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
            yield return new TextBlock { Id = Guid.Parse("614c4f60-fb40-4df9-baad-9398924da20a"), Type = TextBlockType.Text, Text = "Through a combination of magic and training, you've learned how to wield wizard weapons more effectively. You gain expert proficiency in the club, crossbow, dagger, heavy crossbow, staff, and unarmed attacks." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("13368f92-2e30-4311-878e-b3eeb4912e3a"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Club.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("5c2f9344-6ae8-4fb4-b12b-711b8e56a433"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Dagger.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("a36984e2-e80c-43dc-93f4-836c20837db4"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Staff.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("923649d6-8e5b-4d7c-92fb-558ecc9acbfa"), Proficiencies.Instances.Expert.ID, Items.RangedWeapons.Instances.Crossbow.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("6317321a-db35-4818-99c7-d2a5bf09862e"), Proficiencies.Instances.Expert.ID, Items.RangedWeapons.Instances.HeavyCrossbow.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("f761b08b-80d4-402d-9e97-3708cdb9e33b"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76c24ba4-04b1-471c-a125-64e60096cdaf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
