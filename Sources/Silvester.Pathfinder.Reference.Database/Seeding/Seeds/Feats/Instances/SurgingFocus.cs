using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurgingFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("117447d4-5ad4-4da9-8bc0-02784929976f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surging Focus",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally you can see falls to 0 Hit Points.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd73800b-f56f-4113-9bfa-b944d6e0ff66"), Type = TextBlockType.Text, Text = "When an ally you can see falls in battle, your fight or flight response triggers a surge in your deity’s might within you. You instantly regain 1 Focus Point." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9164f81d-9b5e-4756-89b7-7c249f991b22"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
