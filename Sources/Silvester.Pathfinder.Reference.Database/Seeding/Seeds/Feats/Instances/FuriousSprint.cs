using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousSprint : Template
    {
        public static readonly Guid ID = Guid.Parse("57a4dc25-dc2f-4f9d-824e-c5e93eddbd1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Sprint",
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
            yield return new TextBlock { Id = Guid.Parse("05d9a542-7b5e-4930-8b20-e30372bff873"), Type = TextBlockType.Text, Text = "You rush forward. (action: Stride) up to five times your Speed in a straight line. You can increase the number of actions this activity takes to 3 to (action: Stride) up to eight times your Speed in a straight line instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d0a2f3c-4b48-4239-95cf-52a8941d0bb9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
