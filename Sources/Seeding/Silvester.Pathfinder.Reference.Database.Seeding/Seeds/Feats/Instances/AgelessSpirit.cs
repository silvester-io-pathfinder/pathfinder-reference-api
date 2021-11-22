using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgelessSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("5ad6e958-051d-4888-adcb-0b1b438e67da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ageless Spirit",
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
            yield return new TextBlock { Id = Guid.Parse("847816ff-1b69-4955-9662-349d7cb850ea"), Type = TextBlockType.Text, Text = "You remember more about your previous incarnations than most leshys. During your daily preparations, you can meditate upon fragmentary memories of your past lives to gain the trained proficiency rank in one skill of your choice. This proficiency lasts until you prepare again. Since this proficiency is temporary, you can't use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a47d96cd-e836-479d-88ba-52f096353a54"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
