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
        public static readonly Guid ID = Guid.Parse("4c0fbc41-1eb2-418f-9418-caa8efd46c40");

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
            yield return new TextBlock { Id = Guid.Parse("48356706-7d64-48fb-b664-3b7f94082919"), Type = TextBlockType.Text, Text = "You�ve mastered a rogue�s fighting moves. Your proficiency ranks increase to master for all simple weapons and unarmed attacks plus the rapier, sap, shortbow, and shortsword." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("7bef5410-86bd-46a6-a631-0dda6e3c05ba"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("1011615b-4b8c-4977-99f8-c159212b50bf"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("5b974a46-c1f7-4b79-a674-ecac5a752367"), Proficiencies.Instances.Master.ID, Items.MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("3ca18dcb-856a-42bf-ad52-0ad4e7fb010d"), Proficiencies.Instances.Master.ID, Items.MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("dd4bfdd9-a82f-46d4-ac85-037de9ab7ce8"), Proficiencies.Instances.Master.ID, Items.MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("5b9c77eb-d253-40e9-88a1-9725d28aa741"), Proficiencies.Instances.Master.ID, Items.RangedWeapons.Instances.Shortbow.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f82bf2f8-392c-42f9-ae9e-4b281b8d1e57"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
