using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExhalePoison : Template
    {
        public static readonly Guid ID = Guid.Parse("c3b15e6d-3c05-4e6a-82ac-c2b1a4b9afa8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Exhale Poison",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a6cc68e-46fc-44e1-a0ea-5b0bf4af3631"), Type = TextBlockType.Text, Text = "You sharply exhale the poison that previously surrounded you in a 15-foot cone. Creatures in the area are affected by the poison; the poison’s DC and effects are unchanged." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2eaafdf-ba5d-446f-b736-df4c8186591e"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
