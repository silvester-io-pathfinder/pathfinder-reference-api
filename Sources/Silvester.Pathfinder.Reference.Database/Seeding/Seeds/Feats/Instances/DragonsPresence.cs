using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonsPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("51e221e0-418d-4592-b4f0-410e26cff7a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Presence",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b71dd56-64b8-4d8e-bf4e-972bd2f28ebb"), Type = TextBlockType.Text, Text = "As a member of dragonkind, you project unflappable confidence (that collapses catastrophically against the deadliest foes). When you roll a success on a saving throw against a (trait: fear) effect, you get a critical success instead. When you roll a failure against a (trait: fear) effect, you get a critical failure instead." };
            yield return new TextBlock { Id = Guid.Parse("cf633bbb-0012-4470-8e8a-7b1c61f0d1e9"), Type = TextBlockType.Text, Text = "In addition, when you attempt to (action: Demoralize) a foe of your level or lower, you gain a +1 circumstance bonus to the Intimidation check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68f45148-0f5d-4190-9e0e-3b51dc940932"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
