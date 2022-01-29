using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Stonewalker : Template
    {
        public static readonly Guid ID = Guid.Parse("9041f614-dee0-47e3-b897-24f169668817");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stonewalker",
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
            yield return new TextBlock { Id = Guid.Parse("25c5b0ee-9bcf-4e4f-a9bc-c067982c7ebb"), Type = TextBlockType.Text, Text = $"You have a deep reverence for and connection to stone. You gain {ToMarkdownLink<Models.Entities.Spell>("meld into stone", Spells.Instances.MeldIntoStone.ID)} as a 3rd-level divine innate spell that you can cast once per day." };
            yield return new TextBlock { Id = Guid.Parse("34143122-93eb-4f46-bf1b-f85ca992bb79"), Type = TextBlockType.Text, Text = $"If you have the {ToMarkdownLink<Models.Entities.Feat>("Stonecunning", Feats.Instances.Stonecunning.ID)} dwarf ancestry feat, you can attempt to find unusual stonework and stonework traps that require legendary proficiency in Perception. If you have both {ToMarkdownLink<Models.Entities.Feat>("Stonecunning", Feats.Instances.Stonecunning.ID)} and legendary proficiency in Perception, when you're not {ToMarkdownLink<Models.Entities.Action>("Seeking", Actions.Instances.Seek.ID)} and the GM rolls a secret check for you to notice unusual stonework, you keep the bonus from {ToMarkdownLink<Models.Entities.Feat>("Stonecunning", Feats.Instances.Stonecunning.ID)} and don't take the -2 circumstance penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b45671fe-7280-457e-a6a8-92a573423fd2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
