using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepFreeze : Template
    {
        public static readonly Guid ID = Guid.Parse("f1309152-11b7-421f-abbe-33c3444151d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deep Freeze",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc38e874-703e-4c64-b717-ad551d1708bf"), Type = TextBlockType.Text, Text = $"You vent a jet of supercooled fluid from your innovation, damaging a foe and slowing it down. Target one creature within 60 feet. That creature takes cold damage equal to your level, with effects depending on its Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("e89bf06a-f614-43e4-a9c2-36cbb50951e8"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("27882cd2-9f38-43fc-8fcb-641e961a32b0"), Type = TextBlockType.Text, Text = $"~ Unstable Function: Your innovation discharges an enormous cone of supercooled fluid, potentially causing cascading failures. Add the {ToMarkdownLink<Models.Entities.Trait>("unstable", Traits.Instances.Unstable.ID)} trait to Deep Freeze. The ability affects all creatures within a 60-foot cone instead of a single target, and it deals cold damage equal to double your level instead of equal to your level." };
            yield return new TextBlock { Id = Guid.Parse("e567a39d-6913-44ec-a289-addd589bc1f4"), Type = TextBlockType.Text, Text = $":&gt; If you have the revolutionary innovation class feature, you can choose a 60-foot or 90-foot cone when you use an {ToMarkdownLink<Models.Entities.Trait>("unstable", Traits.Instances.Unstable.ID)} Deep Freeze." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2673464d-30e9-4b3f-ac0f-131a4abe2aad"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage and takes a –5-foot status penalty to its Speeds for 1 round.",
                Failure = "The target takes full damage and takes a –10-foot status penalty to its Speeds for 1 round.",
                CriticalFailure = "The target takes double damage, is slowed 1 for 1 round, and takes a –15-foot status penalty to its Speeds for 1 round.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8776866d-c730-48df-b51a-53cd9fe4597d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
