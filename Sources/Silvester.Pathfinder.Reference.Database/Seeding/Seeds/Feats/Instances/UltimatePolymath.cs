using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UltimatePolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("a42f5aec-6352-4d0d-939e-e99b82890d47");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ultimate Polymath",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41ac78f3-53cc-461b-90e8-d9e2f9673f29"), Type = TextBlockType.Text, Text = "You can flexibly cast all of your spells, granting a dizzying array of possible options. All of the spells in your repertoire are signature spells for you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("302982a1-88a8-473a-af57-0ccbac4e06a5"), Muses.Instances.Polymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0a74c56-d7c7-4598-806c-852ba9004d4f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
