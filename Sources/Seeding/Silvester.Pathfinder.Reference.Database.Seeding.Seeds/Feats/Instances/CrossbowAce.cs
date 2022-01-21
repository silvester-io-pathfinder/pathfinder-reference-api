using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossbowAce : Template
    {
        public static readonly Guid ID = Guid.Parse("5e9666c0-0786-4fa0-a0b5-b826f866cc0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossbow Ace",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c8530af-9bb1-4dc9-8e8e-7a9a7a405970"), Type = TextBlockType.Text, Text = $"You have a deep understanding of the crossbow. When you're wielding a crossbow and use {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} or use {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload your crossbow, you gain a +2 circumstance bonus to the damage roll on your next {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with that crossbow. If the crossbow is a simple crossbow, also increase the damage die size for that attack by one step (page 279). You must make the attack before the end of your next turn or these benefits are lost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71995726-08da-4db2-9095-4be62095a022"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
