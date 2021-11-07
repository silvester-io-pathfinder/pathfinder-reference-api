using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallBondedItem : Template
    {
        public static readonly Guid ID = Guid.Parse("03daa187-5676-4321-b2d7-67451560119d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Bonded Item",
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
            yield return new TextBlock { Id = Guid.Parse("73ab7020-bd26-470d-809c-d00835a580e9"), Type = TextBlockType.Text, Text = "You’re mystically connected to your bonded item and can call it to your hand. If your bonded item is 1 Bulk or less, you teleport your bonded item into your hand from up to 1 mile away." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("05d2a418-80b4-4927-8926-da81205a803c"), ClassFeatures.Wizards.ArcaneBond.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fec2042a-1ddb-4404-81cf-30b832802a1f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
