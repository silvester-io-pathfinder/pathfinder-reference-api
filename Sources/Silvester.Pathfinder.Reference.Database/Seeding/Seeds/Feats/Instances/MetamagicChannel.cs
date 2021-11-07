using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetamagicChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("f3f0c18e-b398-4696-a90c-5ac89d86ae9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Metamagic Channel",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("844c2700-52fa-4a34-a626-8ccbac11514a"), Type = TextBlockType.Text, Text = "Deep understanding of divine revelations into the nature of vital essence allows you to freely manipulate the effects of your positive or negative energy. Use 1 metamagic action that you can perform that normally takes 1 action and can be applied to the (spell: harm) or (spell: heal) spell. If you use it in this way, its effects apply only to a (spell: harm) or (spell: heal) spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17739838-8377-4ebd-9ced-b53305f0b704"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
