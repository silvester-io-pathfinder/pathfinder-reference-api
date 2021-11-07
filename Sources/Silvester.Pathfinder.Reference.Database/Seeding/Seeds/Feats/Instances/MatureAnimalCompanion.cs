using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MatureAnimalCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("ab32e961-63e4-42ae-86f4-1e6744bfd58f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mature Animal Companion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28bf7c9d-ef8e-4421-8941-0cb1f6641f06"), Type = TextBlockType.Text, Text = "Your animal companion grows up, becoming a mature animal companion, which grants it additional capabilities. See the (Feat: animal companion) rules on page 214 for more information. Your animal companion is better trained than most. During an encounter, even if you don’t use the (Action: Command an Animal) action, your animal companion can still use 1 action on your turn that round to (Action: Stride) or (Action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ed352b4-51c8-4e6c-8821-00b1c8bfdf78"), Feats.Instances.AnimalCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92ff641d-320d-4d17-8b9c-83018947fa02"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
