using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessedOneDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("190eca11-3f57-4483-9969-22939e186276");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed One Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the blessed one archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f54168d-126d-48b6-9a39-b229eb897037"), Type = TextBlockType.Text, Text = "You are touched by a deity and gifted with the ability to alleviate the suffering of others. You gain the (spell: lay on hands) devotion spell. It costs 1 Focus Point to cast a focus spell. This feat grants a focus pool of 1 Focus Point that you can recover using the (action: Refocus) activity. You can (action: Refocus) by meditating, whether you reflect on the deity granting the blessing or not, allowing your blessing to refill your focus pool. Your devotion spells from the blessed one archetype are divine spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e51c1019-c31c-4430-98f4-306485995a51"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
