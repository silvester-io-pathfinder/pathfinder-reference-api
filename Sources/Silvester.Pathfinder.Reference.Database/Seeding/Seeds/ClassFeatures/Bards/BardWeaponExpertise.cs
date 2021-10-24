using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class BardWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11, 
                Name = "Bard Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have become thoroughly adept with bardic weapons. You gain expert proficiency in simple weapons and unarmed attacks, plus the longsword, rapier, sap, shortbow, shortsword, and whip. When you critically succeed at an attack roll using one of these weapons or an unarmed attack while one of your compositions is active, you apply the critical specialization effect for that weapon or unarmed attack." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Longsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Whip.ID);
            
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, RangedWeapons.Instances.Shortbow.ID);

            //TODO: Add crit effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
