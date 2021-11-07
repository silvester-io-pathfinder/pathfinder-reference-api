using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetamagicChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("ee2a9cad-2c3a-4db2-ad5e-7373a0426cab");

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
            yield return new TextBlock { Id = Guid.Parse("f080bf6b-bd0b-488b-8ca7-a12e1cc3b793"), Type = TextBlockType.Text, Text = "Deep understanding of divine revelations into the nature of vital essence allows you to freely manipulate the effects of your positive or negative energy. Use 1 metamagic action that you can perform that normally takes 1 action and can be applied to the (spell: harm) or (spell: heal) spell. If you use it in this way, its effects apply only to a (spell: harm) or (spell: heal) spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33030aa9-5b7a-46cf-901b-a3206d700898"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
