using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class Resolve : Template
    {
        public static readonly Guid ID = Guid.Parse("4bbde6b4-2579-4c7b-bc35-228603e12e4f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Resolve", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6d2aaf3d-daaa-4b5f-87b7-86b26efc8409"), Type = TextBlockType.Text, Text = "you've steeled you mind with resolve. Your proficiency rank for Will saves increase to master. When you roll a success at a Will save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("a889237b-5094-4428-8f39-7deb3e448687"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("f13dda0c-41c8-43cf-8b12-682163eda8d4"), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27f27a01-1ef5-4892-96af-baa00af7585b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
