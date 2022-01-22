using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrabAndSting : Template
    {
        public static readonly Guid ID = Guid.Parse("7baa8b19-ffaf-467c-9f85-303dc24459b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grab and Sting",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76331cc3-a5e5-4f06-afd0-15db81567a5b"), Type = TextBlockType.Text, Text = $"The scorpion holds its foe in place with its pincers in order to sting it. It makes a pincer {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, the target creature automatically becomes grabbed by the scorpion, which then makes a stinger {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against it. The grabbed condition lasts until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b268f98-0e6a-4379-8a4e-cdc2ac1a11d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
