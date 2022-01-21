using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClueIn : Template
    {
        public static readonly Guid ID = Guid.Parse("8ca0e3e0-8427-427a-8f5b-ead6aae701ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clue In",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Another creature attempts a check to investigate a lead you're pursuing.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91266a7d-2661-42ab-9cce-d41d23635316"), Type = TextBlockType.Text, Text = $"You share information with the triggering creature. They gain a circumstance bonus to their check equal to your circumstance bonus to checks investigating your subject from {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)}. The GM can add any relevant traits to this reaction depending on the situation, such as {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} and {ToMarkdownLink<Models.Entities.Trait>("linguistic", Traits.Instances.Linguistic.ID)} if you're conveying information verbally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bb76aa2-9789-4920-bc7d-241552bc2dc9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
