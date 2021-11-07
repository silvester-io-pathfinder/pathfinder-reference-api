using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MimicProtections : Template
    {
        public static readonly Guid ID = Guid.Parse("326e740d-22f3-4728-ba13-a4d8d71c1b6c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mimic Protections",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfdf7b34-a928-4039-855d-144d5e978d37"), Type = TextBlockType.Text, Text = "By adopting resonant reflections, you have learned to copy the abilities of other creatures as well. When you use (feat: Hunt Prey) on a foe within 100 feet, you gain resistance 10 to all damage types that target has resistance or immunity to for as long as the foe remains within 100 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1defb18e-d868-4af1-96a0-42fb1e639ca7"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
