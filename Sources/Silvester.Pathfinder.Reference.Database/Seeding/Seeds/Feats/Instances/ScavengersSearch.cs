using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScavengersSearch : Template
    {
        public static readonly Guid ID = Guid.Parse("364cd843-177b-4018-80d3-e4400feaf118");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scavenger's Search",
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
            yield return new TextBlock { Id = Guid.Parse("e85ae0c1-aee2-40aa-a107-6cf8a26c5d2f"), Type = TextBlockType.Text, Text = "You&#39;re always on the lookout for supplies and valuables. Each time you use the (action: Seek) action to search for objects (including secret doors and hazards), you can search for objects in your choice of a 10-foot emanation around you or an adjacent 15-foot-by-15-foot area, rather than a single adjacent 10-foot-by-10-foot area." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12d93c4e-c62c-452e-b89b-1a5d54c97b0d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
