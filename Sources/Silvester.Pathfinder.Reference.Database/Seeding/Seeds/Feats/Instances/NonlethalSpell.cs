using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NonlethalSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("d876b929-9595-4c5b-944b-175d9ea62a72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nonlethal Spell",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad3176bc-7371-4f1a-9d83-76b25c27457a"), Type = TextBlockType.Text, Text = "You can alter offensive spells to be less deadly. If your next action is to (activity: Cast a Spell) that deals damage and doesn’t have the (trait: death) or (trait: negative) trait, that spell gains the (trait: nonlethal) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5c47375-0951-4244-9a8f-1bd1c3e81350"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
