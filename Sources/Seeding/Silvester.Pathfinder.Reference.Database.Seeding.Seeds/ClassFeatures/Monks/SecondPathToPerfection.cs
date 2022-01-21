using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class SecondPathToPerfection : Template
    {
        public static readonly Guid ID = Guid.Parse("6def3f86-3008-49c1-ad17-b37b60291403");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Second Path to Perfection", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("70bc2ed9-3f7c-4c17-aa7f-4329feb9c8b8"), Type = TextBlockType.Text, Text = "You�ve learned to find perfection in every success. Choose a different saving throw than the one you chose for your path to perfection. Your proficiency rank for the chosen saving throw increases to master. If you roll a success with the chosen saving throw, you instead critically succeed." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySavingThrowProficiency(Guid.Parse("0d659542-f31f-4aa8-9f1d-06cf554f469b"), Proficiencies.Instances.Master.ID);
            builder.ImproveAnySavingThrow(Guid.Parse("3a21b54a-8d0a-4e11-b331-301b4d419018"), RollResult.Success, becomes: RollResult.CriticalSuccess); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3004fa2f-d87b-4292-bc32-e2faf4907006"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
