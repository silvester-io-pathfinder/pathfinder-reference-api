using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CharredRemains : Template
    {
        public static readonly Guid ID = Guid.Parse("d3bb26ef-531d-4dc5-85f8-81c58b929005");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charred Remains",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25dcd05d-afe7-42ff-be18-fd46661fe423"), Type = TextBlockType.Text, Text = "Your next fire spell leaves embers in its wake. If your next action is to (action: Cast a Spell) with an area and the (trait: fire) trait, for 1 minute, your spell’s area becomes difficult terrain as well as hazardous terrain, dealing 1 fire damage for each square a creature moves through." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b9c9e84-8f97-4562-8a30-b89c5b72fac7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
