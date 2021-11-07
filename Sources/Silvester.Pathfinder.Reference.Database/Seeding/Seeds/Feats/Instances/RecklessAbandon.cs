using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecklessAbandon : Template
    {
        public static readonly Guid ID = Guid.Parse("2306e590-aad9-4a9e-aad3-1b31a7d65442");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reckless Abandon",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f9e6a90-0ad8-4961-b1b4-8b11dc3844ef"), Type = TextBlockType.Text, Text = "Despite a lifetime filled with questionable decisions, you’ve managed to survive, as though you have uncanny luck that lets you avoid the consequences of your own actions. For the remainder of your turn, if you roll a failure or critical failure on a saving throw against a harmful effect, you get a success instead. Further, enemies and hazards that would damage you this turn roll the minimum possible damage." };
            yield return new TextBlock { Id = Guid.Parse("ccd0055e-d4e4-4bd6-9fe0-eb259327f729"), Type = TextBlockType.Text, Text = "These benefits apply only to harmful effects incurred entirely during your turn in which you activate Reckless Abandon, such as running through a (spell: prismatic wall). Persistent damage and conditions that were applied prior to your turn proceed normally, and as soon as your turn ends you are subject to the full consequences of any dangers still threatening you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2db2dbaf-dd19-4131-85b0-e31df4fae474"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
