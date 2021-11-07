using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DirgeOfDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("d853e7f8-ea1c-444f-8847-7ff4d8c1f236");

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
            yield return new TextBlock { Id = Guid.Parse("25e4de8c-a3fc-4074-9dfd-bb685ef5524f"), Type = TextBlockType.Text, Text = "You learn the (spell: dirge of doom) composition cantrip, which frightens your enemies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("172d7037-b543-427d-b8ab-c9e324820de8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
