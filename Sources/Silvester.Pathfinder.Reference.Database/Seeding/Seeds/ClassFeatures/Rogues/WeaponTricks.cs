using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class WeaponTricks : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Weapon Tricks", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have become thoroughly familiar with the tools of your trade. You gain expert proficiency in simple weapons and unarmed attacks, as well as the rapier, sap, shortbow, and shortsword. When you critically succeed at an attack roll against a flat-footed creature while using an agile or finesse simple weapon or any of the listed weapons, you apply the critical specialization effect for the weapon you’re wielding." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, RangedWeapons.Instances.Shortbow.ID);

            //TODO: Add crit specialization effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
