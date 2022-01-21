using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class WeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("ccf6f1d3-d144-4454-9946-35b64b91d6a6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Weapon Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9074b30e-1b07-47b1-934f-52af11b47d57"), Type = TextBlockType.Text, Text = "You fully understand your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("86581538-df01-459c-83ab-056e5878e968"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("2515c735-a083-4332-a4b6-295a3a0ec6c3"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("545c8903-5b6c-4bb2-961f-4d4bbafc6810"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("034812b4-dbc0-4423-8f8f-e59c5adce506"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
