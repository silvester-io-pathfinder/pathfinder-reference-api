using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AllTheTimeInTheWorld : Template
    {
        public static readonly Guid ID = Guid.Parse("929b2296-4d48-4f23-bc07-abfd26c2573b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "All the Time in the World",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fb36604-3c7c-4262-a3ba-4d17fedd156c"), Type = TextBlockType.Text, Text = "Your firsthand experience of the subjective nature of time and space has given you new observational insights. Your mind processes information so quickly that time appears to stop for all creatures but you. You can take up to 9 actions in 3 sets of up to 3 actions each. During this time, you can use purely mental and observational abilities such as (action: Recall Knowledge), (action: Seek), and (action: Devise a Stratagem), and you can use an action to move a mental projection of yourself to a location within a 60- foot radius to observe objects more closely and from different angles, though you can&#39;t affect your surroundings in any way (for instance, you could move your mental projection more closely to a distant door to read a minute inscription on its handle, but you could not open it to observe the other side). When the duration elapses, time resumes its normal flow." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("637be127-a13f-48b4-979f-b4d4b66452bb"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
