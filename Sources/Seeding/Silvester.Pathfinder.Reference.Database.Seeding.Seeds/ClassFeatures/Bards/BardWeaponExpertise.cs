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
        public static readonly Guid ID = Guid.Parse("239ae61d-cd92-4676-bea0-7b45ba9872e5");

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
            yield return new TextBlock { Id = Guid.Parse("8fe3849e-72da-4e4d-b0b1-cedc0fdd5f12"), Type = TextBlockType.Text, Text = "You have become thoroughly adept with bardic weapons. You gain expert proficiency in simple weapons and unarmed attacks, plus the longsword, rapier, sap, shortbow, shortsword, and whip. When you critically succeed at an attack roll using one of these weapons or an unarmed attack while one of your compositions is active, you apply the critical specialization effect for that weapon or unarmed attack." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("8521e6c9-c082-4b49-a85a-cf7dbaec8ae0"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("983fcf33-fbe3-48a4-90ee-a80b44761b5a"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("9b0c7dac-64b2-4b30-8d46-0cf09d8de245"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Longsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("62b87b20-af1e-42b3-be45-711d5c503f4e"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("adce44f0-8ab4-4136-b6f8-482a17302887"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("3280081f-af9c-4231-b334-8810e60726c1"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("c0998602-adf0-4ae5-adde-9746e68bbb2f"), Proficiencies.Instances.Expert.ID, Items.MeleeWeapons.Instances.Whip.ID);
            
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("ee7e5cb9-0d96-4ae6-a72e-bc5e87db52d5"), Proficiencies.Instances.Expert.ID, Items.RangedWeapons.Instances.Shortbow.ID);

            //TODO: Add crit effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("664b1707-c315-4fcf-83c1-39a8a9af1e35"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
