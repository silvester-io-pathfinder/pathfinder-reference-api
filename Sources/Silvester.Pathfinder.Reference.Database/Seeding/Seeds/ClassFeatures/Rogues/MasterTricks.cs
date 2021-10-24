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
    public class MasterTricks : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Master Tricks", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’ve mastered a rogue’s fighting moves. Your proficiency ranks increase to master for all simple weapons and unarmed attacks plus the rapier, sap, shortbow, and shortsword." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, RangedWeapons.Instances.Shortbow.ID);
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
