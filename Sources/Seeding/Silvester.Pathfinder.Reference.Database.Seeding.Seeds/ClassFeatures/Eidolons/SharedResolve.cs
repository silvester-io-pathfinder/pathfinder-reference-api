using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class SharedResolve : Template
    {
        public static readonly Guid ID = Guid.Parse("2a548b8f-aa96-4f64-9ad8-0024ab32a925");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Shared Resolve", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b72b3c7e-5b57-407e-a6b0-44c4ad79015b"), Type = TextBlockType.Text, Text = "You and your eidolon steel your mind together against effects that threaten you, each protecting the others' minds from danger. Your and your eidolon's proficiency ranks for Will saves increase to master. When you roll a success on a Will save, you get a critical success instead. When your eidolon rolls a success on a Will save, it gets a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("8a13c3bb-8945-4bf0-9b89-a6b88a2e4c00"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("1fe75dc9-8d6e-4715-98c6-5d921d6fc61f"), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b708b0fc-abcd-45fa-bd50-317687a3b410"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
