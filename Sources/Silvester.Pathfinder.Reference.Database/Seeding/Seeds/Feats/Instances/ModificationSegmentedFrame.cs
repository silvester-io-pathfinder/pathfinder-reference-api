using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationSegmentedFrame : Template
    {
        public static readonly Guid ID = Guid.Parse("d46c0966-7fa5-4153-ac5c-f34584129c39");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Segmented Frame",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aaacef1e-a242-4791-b5d2-bb9022dd0682"), Type = TextBlockType.Text, Text = "Hinges, clamps, and telescoping parts make your innovation collapsible and adjustable. It gains the (trait: modular | modular B, P, or S) trait for bludgeoning, piercing, and slashing. You can (action: Interact) to collapse the item down to light Bulk or to return it to your normal form. When it’s collapsed to light Bulk, it has the (trait: concealable) trait, which grants you a +2 circumstance bonus to Stealth checks and DCs to hide or conceal the weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fda72065-1030-4ce8-af0b-75fcfb438cd0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
