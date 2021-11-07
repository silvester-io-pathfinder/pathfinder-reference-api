using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AstralBlink : Template
    {
        public static readonly Guid ID = Guid.Parse("b55ffd5c-5279-4b34-ba2f-2909f0da452e");

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
            yield return new TextBlock { Id = Guid.Parse("8f05dc5b-adbb-4dec-9db5-0e1d56c5302b"), Type = TextBlockType.Text, Text = "You’ve attuned your core to allow you to phase in and out of the Astral Plane, allowing you to teleport periodically. You can cast (spell: dimension door) once per hour as a 4th-level innate arcane spell." };
            yield return new TextBlock { Id = Guid.Parse("62558158-abbc-409a-aa80-3490128dabf0"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("27a90b33-251b-4dc6-bb85-dcc211461a4f"), Type = TextBlockType.Text, Text = "~ Enhancement: Your attunement allows you to teleport in a series of quick jumps rather than in one big leap. You can expend your hourly use of (spell: dimension door) as a free action when you begin your turn. If you do, your (action: Strides | Stride) are augmented until the end of your turn, allowing you to instantly teleport to any point you could reach with your Speed instead of traversing normally to the location. While augmented, your (action: Strides | Stride) gain the (trait: conjuration) and (trait: teleportation) traits. Your augmented (action: Strides | Stride) don’t trigger reactions that can be triggered by (trait: move) actions or upon leaving or entering a square, unless those reactions trigger on teleportation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd21b77b-2b9d-4839-a3c1-fd2e8b5569da"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
