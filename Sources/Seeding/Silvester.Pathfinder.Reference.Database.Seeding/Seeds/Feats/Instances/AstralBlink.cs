using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AstralBlink : Template
    {
        public static readonly Guid ID = Guid.Parse("08ff8567-760a-4faa-9c9c-4fda4c0ce90e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Astral Blink",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de6f697c-9bea-4992-986d-e7895e4454c9"), Type = TextBlockType.Text, Text = "You've attuned your core to allow you to phase in and out of the Astral Plane, allowing you to teleport periodically. You can cast (spell: dimension door) once per hour as a 4th-level innate arcane spell." };
            yield return new TextBlock { Id = Guid.Parse("249eefca-ecda-4c49-9551-0ecf607d4422"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("a280f264-e4fd-4863-85cf-052b0c60498f"), Type = TextBlockType.Text, Text = "~ Enhancement: Your attunement allows you to teleport in a series of quick jumps rather than in one big leap. You can expend your hourly use of (spell: dimension door) as a free action when you begin your turn. If you do, your (action: Strides | Stride) are augmented until the end of your turn, allowing you to instantly teleport to any point you could reach with your Speed instead of traversing normally to the location. While augmented, your (action: Strides | Stride) gain the (trait: conjuration) and (trait: teleportation) traits. Your augmented (action: Strides | Stride) don't trigger reactions that can be triggered by (trait: move) actions or upon leaving or entering a square, unless those reactions trigger on teleportation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49a665ce-6b89-4dba-9c5c-d1150307d9db"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
