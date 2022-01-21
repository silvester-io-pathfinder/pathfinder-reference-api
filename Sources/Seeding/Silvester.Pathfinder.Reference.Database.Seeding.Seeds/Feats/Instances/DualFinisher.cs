using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("e5d10b56-1dc9-4efa-86c1-713ccf09a901");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Finisher",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4cbcbb8-7d5c-4ae6-929e-35408153f40c"), Type = TextBlockType.Text, Text = $"You split your attacks. Make two melee {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, one with each required weapon, each against a different foe. If the second {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is made with a non-{ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} weapon, it takes a -2 penalty. Increase your multiple attack penalty only after attempting both {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d4dd28d-f757-4bd0-9706-d451233338db"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
