using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnduringAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("42d7224a-9e71-4799-96ea-426e5ecb0cb4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enduring Alchemy",
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
            yield return new TextBlock { Id = Guid.Parse("2254523a-cef6-41ad-8044-b9716039c310"), Type = TextBlockType.Text, Text = $"You've learned how to make your personal energy last just a little bit longer when quickly brewing ad hoc concoctions. When using {ToMarkdownLink<Models.Entities.Feat>("Quick Alchemy", Feats.Instances.QuickAlchemy.ID)} to create an alchemical tool or elixir, that tool or elixir remains potent until the end of your next turn, instead of losing its potency at the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26f794e3-344e-42c3-8a21-a344c2d26058"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
