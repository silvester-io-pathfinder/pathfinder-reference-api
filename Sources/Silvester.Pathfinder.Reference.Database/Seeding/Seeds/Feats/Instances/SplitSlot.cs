using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplitSlot : Template
    {
        public static readonly Guid ID = Guid.Parse("8505e39d-b632-4a6b-bfac-590fd6e984d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Split Slot",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9906ac11-81c2-47cf-bc9d-c62109f476f1"), Type = TextBlockType.Text, Text = "You can prepare two spells in one slot, giving you the freedom to choose the spell when you cast it. When you prepare your spells for the day, you can choose one spell slot at least 1 level lower than the highest-level spell you can cast and prepare two spells in that slot. When you (activity: Cast a Spell) from that slot, choose which spell to cast. Once you’ve chosen, the unused spell dissipates as though you hadn’t prepared it at all–for example, it isn’t available for use with (feat: Drain Bonded Item)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("634d471c-dabb-4acc-abb4-f3a434a296dd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
