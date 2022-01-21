using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LabRat : Template
    {
        public static readonly Guid ID = Guid.Parse("66de480a-3586-45d2-8fa6-8cf6df4425fc");

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
            yield return new TextBlock { Id = Guid.Parse("82065e63-8349-4316-b1cc-a4d9ad70b6f1"), Type = TextBlockType.Text, Text = "You've spent more than your share of time in an alchemy lab. You might have been an alchemist yourself, an assistant, or perhaps even a test subject. Either way, you have been exposed to a wide variety of alchemical poisons and elixirs, leaving you with increased tolerance of their effects. You have a +1 circumstance bonus to saves against poison and harmful effects from elixirs. If you roll a success on your saving throw against an elixir or poison, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7ad528c-2d2e-4d17-92ff-c95a80242f8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
