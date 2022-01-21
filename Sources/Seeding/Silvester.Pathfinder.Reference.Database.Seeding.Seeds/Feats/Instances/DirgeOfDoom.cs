using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DirgeOfDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("9fce8cea-daa7-495e-b261-7f1dd9cb3691");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dirge of Doom",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("237c5a87-9979-430f-90ea-25a27ede82e2"), Type = TextBlockType.Text, Text = $"You learn the {ToMarkdownLink<Models.Entities.Spell>("dirge of doom", Spells.Instances.DirgeOfDoom.ID)} composition cantrip, which frightens your enemies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("628876fc-f9d0-4aa3-8347-f66768615771"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
