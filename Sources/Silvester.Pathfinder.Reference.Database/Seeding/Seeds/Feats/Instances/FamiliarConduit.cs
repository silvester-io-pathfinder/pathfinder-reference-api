using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("b025386c-7515-460b-8b82-2ea29d844754");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar Conduit",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1bbffa6-113e-4694-9f4d-b4bd2f597428"), Type = TextBlockType.Text, Text = "Under your tutelage, your familiar has grown attuned to the hidden currents of the world and can serve as a conduit for your magic. If the next action you use is to (activity: Cast a Spell) that has a range, the spell uses the familiar as its origin point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc991132-3507-4012-900e-e0ffd402cfb8"), Feats.Instances.FamiliarMasterDedication.ID);
            builder.HaveAnyMagicTradition(Guid.Parse("688d99c9-b14c-4b47-9a29-695098944011"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bf40400-3b83-4d18-8faa-117354088080"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
