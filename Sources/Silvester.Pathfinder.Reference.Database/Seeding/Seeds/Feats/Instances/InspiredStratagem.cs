using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspiredStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("e310fe8c-8abf-41d8-b2c4-029ad1b86657");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspired Stratagem",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "One of the required allies is about to attempt an attack roll or skill check.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ed117ce-97f1-4286-ac9b-646aad81051d"), Type = TextBlockType.Text, Text = "You quickly advise your ally, using your earlier planning to make sure luck can’t throw a wrench in the cogs of your schemes. The ally rolls the triggering check twice and takes the better of the two results. That ally then becomes temporarily immune to your Inspired Stratagem until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c80b7644-42b9-4266-be35-829e7f88fa6c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
