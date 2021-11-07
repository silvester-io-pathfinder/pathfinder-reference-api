using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Posse : Template
    {
        public static readonly Guid ID = Guid.Parse("37d4fdc3-3936-4afd-88a7-51f522dff856");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Posse",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83431c44-722d-4d3b-aa35-01a6b6ebb0cd"), Type = TextBlockType.Text, Text = "By spending 1 minute giving guidance to help hunt down your prey, you instruct up to five willing creatures to assist you. They gain a +1 circumstance bonus to (action: Seek) your prey, to (action: Track) your prey, and to (action: Gather Information) about your prey. You and the creatures assisting you gain a +1 circumstance bonus to initiative rolls when entering combat with your prey." };
            yield return new TextBlock { Id = Guid.Parse("cd10e3b0-65c8-4fc3-b910-58e94e0944cc"), Type = TextBlockType.Text, Text = "This benefit lasts until you designate a new prey or your prey dies, whichever comes first. An individual creature assisting you loses this benefit if they’re out of your presence for too long to benefit from your instructions. This is usually 1 hour, but is determined by the GM." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb4a5837-4d61-45eb-b0e3-0f2bc2cce646"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3706e88e-d2d6-472c-93b8-514a79d89c6e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
