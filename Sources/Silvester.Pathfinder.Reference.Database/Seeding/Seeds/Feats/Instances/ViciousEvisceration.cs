using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ViciousEvisceration : Template
    {
        public static readonly Guid ID = Guid.Parse("ce35a287-0f1e-41a4-9e54-40dcec18e36d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vicious Evisceration",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0556d106-1f06-424b-afa2-d66606e53fc8"), Type = TextBlockType.Text, Text = "You make a vicious attack that maims your enemy. Make a melee (action: Strike). If the (action: Strike) hits and deals damage, the target is drained 1, or drained 2 on a critical success." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ce27e15-45e7-4974-90c3-588e27569234"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
