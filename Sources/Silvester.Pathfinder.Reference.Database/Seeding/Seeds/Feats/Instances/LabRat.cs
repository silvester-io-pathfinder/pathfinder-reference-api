using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LabRat : Template
    {
        public static readonly Guid ID = Guid.Parse("fc47de66-880f-44f2-af61-cd47ffc20508");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lab Rat",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ce46641-4fce-4e30-b945-58079b98b198"), Type = TextBlockType.Text, Text = "You&#39;ve spent more than your share of time in an alchemy lab. You might have been an alchemist yourself, an assistant, or perhaps even a test subject. Either way, you have been exposed to a wide variety of alchemical poisons and elixirs, leaving you with increased tolerance of their effects. You have a +1 circumstance bonus to saves against poison and harmful effects from elixirs. If you roll a success on your saving throw against an elixir or poison, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c50fa07f-7fab-40cf-b998-914266de8cc1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
