using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChangeShapeKitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("3ff75abe-818d-4bcc-a88c-d0398c626f5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Change Shape - Kitsune",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f85a09ab-5150-4d9a-8f62-9d45069801b3"), Type = TextBlockType.Text, Text = "You transform into a specific alternate form determined by your heritage. If your heritage doesn’t list a form, your alternate form is a tailless form, which is a common Medium humanoid ancestry prevalent where you grew up (typically human). This form is the same age and body type as your true form and has roughly analogous physical traits, such as hair color." };
            yield return new TextBlock { Id = Guid.Parse("4726970e-13fa-4364-8676-21a1471991cf"), Type = TextBlockType.Text, Text = "Using Change Shape counts as creating a disguise for the (action: Impersonate) use of Deception. You lose any unarmed (action: Strikes | Strike) you gained from a kitsune heritage or ancestry feat in this form. You can remain in your alternate form indefinitely, and you can shift back to your true kitsune form by using this action again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf2d136a-a687-4bb5-a773-0180cc620f46"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
