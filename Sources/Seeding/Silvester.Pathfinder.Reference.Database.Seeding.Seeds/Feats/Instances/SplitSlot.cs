using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplitSlot : Template
    {
        public static readonly Guid ID = Guid.Parse("dac316f5-5fe6-4989-8f2e-596e3a88a649");

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
            yield return new TextBlock { Id = Guid.Parse("42d569c4-ef08-46a6-823c-7db14e4a46bf"), Type = TextBlockType.Text, Text = "You can prepare two spells in one slot, giving you the freedom to choose the spell when you cast it. When you prepare your spells for the day, you can choose one spell slot at least 1 level lower than the highest-level spell you can cast and prepare two spells in that slot. When you (activity: Cast a Spell) from that slot, choose which spell to cast. Once you've chosen, the unused spell dissipates as though you hadn't prepared it at all–for example, it isn't available for use with (feat: Drain Bonded Item)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed72818a-148c-43cc-9df7-9c71864c9674"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
