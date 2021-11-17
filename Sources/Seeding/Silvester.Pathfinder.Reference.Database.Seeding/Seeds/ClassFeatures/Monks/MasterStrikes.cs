using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class MasterStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("b78c1c49-7137-4db3-abcb-cab7639eef70");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Master Strikes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9027937a-30ab-463b-a069-8af69bc93217"), Type = TextBlockType.Text, Text = "You have honed your skill in using your body as a weapon. Your proficiency ranks for unarmed attacks and simple weapons increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("2fb61487-4ae9-47b9-bed6-af37c45cef65"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("c8f47c01-711d-4497-8228-3bd786c883e5"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20c8db4f-896d-47d2-89f1-48d9aab611cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
