using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class Resolve : Template
    {
        public static readonly Guid ID = Guid.Parse("5f3db5f5-e0ff-48b9-9cae-2a28670c5e6c");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Resolve", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6d845c59-19a5-486d-bb39-a451d416231c"), Type = TextBlockType.Text, Text = "you've steeled your mind with resolve. Your proficiency rank for Will saves increases to master. When you roll a success at a Will save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("ff6605c2-5b98-446d-a81e-6653ca872593"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("0805300b-049f-4956-82fd-5960e5e27792"), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c692f72d-83d7-4333-9aee-7dff0c792d1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 121
            };
        }
    }
}
