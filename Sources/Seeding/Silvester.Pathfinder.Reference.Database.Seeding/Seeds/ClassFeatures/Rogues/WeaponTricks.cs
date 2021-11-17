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
        public static readonly Guid ID = Guid.Parse("0d451a26-e817-46b9-a10c-a83d7ea9a80b");

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
            yield return new TextBlock { Id = Guid.Parse("400ab7f4-fafb-480c-998c-47d9fbe1d2c5"), Type = TextBlockType.Text, Text = "You have become thoroughly familiar with the tools of your trade. You gain expert proficiency in simple weapons and unarmed attacks, as well as the rapier, sap, shortbow, and shortsword. When you critically succeed at an attack roll against a flat-footed creature while using an agile or finesse simple weapon or any of the listed weapons, you apply the critical specialization effect for the weapon you�re wielding." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("9f386491-c4c1-4c5a-94a2-596ad3631cd8"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("8ebcd1b1-bb53-470f-b896-f536937875e9"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("b9b305f2-e0b6-4ba9-8fad-c75bd351042e"), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("71e8b73f-3f74-46ed-bb87-68e989338305"), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("efd519a5-0ca3-4f48-abb9-3021597b6785"), Proficiencies.Instances.Expert.ID, MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("5fabdbf8-3b2d-46ba-b8e2-9336f2c870f2"), Proficiencies.Instances.Expert.ID, RangedWeapons.Instances.Shortbow.ID);

            //TODO: Add crit specialization effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd50d4b5-0a11-467b-892d-19341685bd68"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
