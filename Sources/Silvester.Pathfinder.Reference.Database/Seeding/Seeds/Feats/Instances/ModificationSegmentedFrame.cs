using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationSegmentedFrame : Template
    {
        public static readonly Guid ID = Guid.Parse("269c244d-4364-4e96-af82-64679c737d4f");

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
            yield return new TextBlock { Id = Guid.Parse("8282644f-4e8a-4005-a101-4b823b328557"), Type = TextBlockType.Text, Text = "Hinges, clamps, and telescoping parts make your innovation collapsible and adjustable. It gains the (trait: modular | modular B, P, or S) trait for bludgeoning, piercing, and slashing. You can (action: Interact) to collapse the item down to light Bulk or to return it to your normal form. When it’s collapsed to light Bulk, it has the (trait: concealable) trait, which grants you a +2 circumstance bonus to Stealth checks and DCs to hide or conceal the weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5f8d56f-b178-4762-b5ed-751d1bd45825"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
