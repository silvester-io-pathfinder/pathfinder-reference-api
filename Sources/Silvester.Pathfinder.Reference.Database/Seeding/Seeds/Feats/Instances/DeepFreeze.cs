using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepFreeze : Template
    {
        public static readonly Guid ID = Guid.Parse("2e76e2a0-9dae-495c-9de2-51a9aa2dd874");

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
            yield return new TextBlock { Id = Guid.Parse("9e05120e-a9b7-401a-a1bd-066d42460d79"), Type = TextBlockType.Text, Text = "You vent a jet of supercooled fluid from your innovation, damaging a foe and slowing it down. Target one creature within 60 feet. That creature takes cold damage equal to your level, with effects depending on its Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("5702fab9-a791-4708-accf-7e5f6758fb1e"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("d66c7310-9c3a-409e-9922-d27ed65b06d5"), Type = TextBlockType.Text, Text = "~ Unstable Function: Your innovation discharges an enormous cone of supercooled fluid, potentially causing cascading failures. Add the (trait: unstable) trait to Deep Freeze. The ability affects all creatures within a 60-foot cone instead of a single target, and it deals cold damage equal to double your level instead of equal to your level." };
            yield return new TextBlock { Id = Guid.Parse("cf8d5b38-a38b-4551-80a3-81b67211c224"), Type = TextBlockType.Text, Text = ":&gt; If you have the revolutionary innovation class feature, you can choose a 60-foot or 90-foot cone when you use an (trait: unstable) Deep Freeze." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6df3d0f9-c34b-48a1-92d7-bd0b993a6340"),
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
                Id = Guid.Parse("f4c984f7-1f7f-4337-9df3-3109b13cc13a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
