using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeterminedToughness : Template
    {
        public static readonly Guid ID = Guid.Parse("77eeb9fe-3ca4-442f-b0a1-b789df069b78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Determined Toughness",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85934460-0845-4b0b-b3f4-a44e4368155e"), Type = TextBlockType.Text, Text = "Any status penalties you take from the following conditions are 1 less than their condition’s value: clumsy, drained, enfeebled, frightened, sickened, stupefied. This doesn’t change the actual condition value, or any other effects of the condition (such as stupefied’s disruption and its DC)." };
            yield return new TextBlock { Id = Guid.Parse("a842e31d-0f3b-4724-9af4-dc44348d69b0"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ Whenever you take a status penalty from the listed conditions, you also take a –1 penalty to the same statistics." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53ed5703-0815-442d-afe8-2f1c0d5e739b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
