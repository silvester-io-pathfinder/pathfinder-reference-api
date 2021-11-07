using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("7c392da9-eae7-46f6-938c-323dd1148782");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95a0c0cb-d2cc-4711-895a-27f6d345c956"), Type = TextBlockType.Text, Text = "Your shapeshifting grants you a magical connection to the animal world. You can cast (spell: animal messenger), (spell: calm emotions) (animals only), and (spell: speak with animals) as 2nd-level primal innate spells once per day each. These spells use your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc3b4f2f-cbcc-4ce8-8027-498624794e56"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
