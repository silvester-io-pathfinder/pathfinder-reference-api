using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlexibleStudies : Template
    {
        public static readonly Guid ID = Guid.Parse("b9ebcb66-1e9c-4d7e-9e93-e42b1a4f70c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Studies",
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
            yield return new TextBlock { Id = Guid.Parse("883ff0c4-1d17-44d2-8a5f-c7b9eb1e780f"), Type = TextBlockType.Text, Text = "You've collected a cross-section of information on various disciplines you can refer to when preparing for various tasks. During your daily preparations, you can cram on a certain subject to become temporarily trained in one skill of your choice. This proficiency lasts until you prepare again. As this proficiency is temporary, you can't use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99cce32c-4f9a-4542-9651-435e678507b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
