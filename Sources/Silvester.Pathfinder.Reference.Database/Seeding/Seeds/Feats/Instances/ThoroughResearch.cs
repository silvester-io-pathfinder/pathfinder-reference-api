using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThoroughResearch : Template
    {
        public static readonly Guid ID = Guid.Parse("98908058-8418-4b24-8865-86b48ac54dbd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thorough Research",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddef8719-2193-4491-9f8e-51ccbfc375ec"), Type = TextBlockType.Text, Text = "When you succeed at a (action: Recall Knowledge) check, you learn an additional fact about the subject. When you critically succeed at a (action: Recall Knowledge) check, you can gain even more additional information or context than normal, at the GM&#39;s discretion." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9916f85-48d9-4b4c-9030-99ab0ac0e325"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
