using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetamagicMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("2dab18e2-7a76-4475-a015-ebad15ec1bf2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Metamagic Mastery",
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
            yield return new TextBlock { Id = Guid.Parse("1d2cefcb-850e-4531-a89c-a4d945833944"), Type = TextBlockType.Text, Text = "Altering your spells doesn’t take any longer than casting them normally. You can use (trait: metamagic) single actions as free actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33b53dc5-8a24-4182-97b7-ea873048da47"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
