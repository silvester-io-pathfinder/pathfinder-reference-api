using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonGrip : Template
    {
        public static readonly Guid ID = Guid.Parse("7aac32ce-62cb-4d72-aebd-6e4eb5450520");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Grip",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46fc4e2c-4efb-4e87-8937-da4c3d263442"), Type = TextBlockType.Text, Text = "Your hold has a unique draconic connection. You gain a +2 circumstance bonus when you attempt to (action: Make an Impression) on a creature with the (trait: dragon) trait. You gain access to the Riding Drake animal companion (Advanced Player’s Guide 145)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9a381e23-d4e7-46ed-a00e-b0a65d55c587"), Feats.Instances.BeastTrainer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57482710-56d1-4aed-9a7c-9b912d861e03"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
