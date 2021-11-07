using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoblinScuttle : Template
    {
        public static readonly Guid ID = Guid.Parse("51a1fbdf-f5c0-4bbd-a928-364271f6a39c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goblin Scuttle",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally ends a move action adjacent to you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7172cd85-65fd-4a71-9b72-28950d6299eb"), Type = TextBlockType.Text, Text = "You take advantage of your ally’s movement to adjust your position. You (action: Step)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccde6586-b754-4da9-a850-08d14319afcb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
