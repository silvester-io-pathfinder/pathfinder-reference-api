using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoremastersEtude : Template
    {
        public static readonly Guid ID = Guid.Parse("3c9fe063-3134-467c-aa14-92e131a9cefb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loremaster's Etude",
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
            yield return new TextBlock { Id = Guid.Parse("e4cbef5d-4ecf-415d-bd66-915610055d2d"), Type = TextBlockType.Text, Text = "You magically unlock memories, making them easier to recall. You learn the (spell: loremaster’s etude) composition spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7e540de0-c2f3-4125-aaa5-6bf62a08a793"), Feats.Instances.LoremasteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bdadf37-dd23-4bb4-9c48-9a27f0bab9e5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
