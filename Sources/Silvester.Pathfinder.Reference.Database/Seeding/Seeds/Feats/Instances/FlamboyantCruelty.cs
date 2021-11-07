using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlamboyantCruelty : Template
    {
        public static readonly Guid ID = Guid.Parse("40068e22-cb58-4fa8-bee1-fbba33c4fbbb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flamboyant Cruelty",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93df4362-5a23-4dd1-b9e4-a88ebfe820b3"), Type = TextBlockType.Text, Text = "You love to kick your enemies when they’re down, and you look fabulous when you do. When you make a melee weapon (action: Strike) against a foe that has at least two of the following conditions, you gain a circumstance bonus to your damage roll equal to the number of these conditions the foe has. The qualifying conditions are clumsy, drained, enfeebled, frightened, sickened, and stupefied. If you hit such a foe, you gain a +1 circumstance bonus to skill checks to (action: Tumble Through) and to perform your style’s panache-granting actions until the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84fb69d2-3066-45c1-a644-1f9478cad3ff"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
