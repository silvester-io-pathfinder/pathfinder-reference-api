using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousCuriosity : Template
    {
        public static readonly Guid ID = Guid.Parse("a92d1247-e9d8-45b2-9ebe-18c3c4579712");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cautious Curiosity",
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
            yield return new TextBlock { Id = Guid.Parse("a471c010-fe9b-4927-bcb1-e61314db5af5"), Type = TextBlockType.Text, Text = "You’ve learned a few magical techniques for getting yourself both into and out of trouble unnoticed. You gain (spell: misdirection) and (spell: silence) as 2nd-level arcane or occult innate spells. The tradition of these spells must match the tradition you use for your gnome ancestry options. You can cast each spell once per day and can target only yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("4a0374c9-3269-440f-9cd3-6772a1051263"), "at least one arcane or occult innate spell gained from a gnome heritage or gnome ancestry feat");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2b25ffe-0004-42df-b18f-85c2e5419344"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
