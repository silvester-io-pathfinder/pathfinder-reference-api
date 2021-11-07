using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PenetratingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("2740563d-554e-4338-981b-92a377d5e4cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Penetrating Shot",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b14015a1-b99d-4984-b081-9f148c72f118"), Type = TextBlockType.Text, Text = "You shoot clear through an intervening creature to hit your prey. Choose a target that is giving lesser cover to your hunted prey. Make a single ranged (action: Strike) with the required weapon against the chosen target and your hunted prey. This attack ignores any lesser cover the chosen target provides your hunted prey. Roll damage only once, and apply it to each creature you hit. A Penetrating Shot counts as two attacks for your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5717d81-7aa6-48af-bd61-1ed213863a5b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
