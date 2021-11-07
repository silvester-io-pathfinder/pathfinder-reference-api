using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TitanSlinger : Template
    {
        public static readonly Guid ID = Guid.Parse("004d499f-b3b0-422d-b0e3-1eb665497f71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan Slinger",
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
            yield return new TextBlock { Id = Guid.Parse("8e0b8b87-a241-4cd2-9917-27d34b783cce"), Type = TextBlockType.Text, Text = "You have learned how to use your sling to fell enormous creatures. When you hit on an attack with a (item: sling) against a Large or larger creature, increase the size of the weapon damage die by one step (details on increasing weapon damage die sizes can be found on page 279)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("add8ffb8-9ef7-4568-8e08-da9e973d1d5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
