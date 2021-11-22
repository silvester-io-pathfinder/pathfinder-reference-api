using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeterminedToughness : Template
    {
        public static readonly Guid ID = Guid.Parse("cb6de3da-5b58-42ec-a459-1e228c6636f9");

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
            yield return new TextBlock { Id = Guid.Parse("ba191250-e287-4ba3-980b-aa76fa553af1"), Type = TextBlockType.Text, Text = "Any status penalties you take from the following conditions are 1 less than their condition's value: clumsy, drained, enfeebled, frightened, sickened, stupefied. This doesn't change the actual condition value, or any other effects of the condition (such as stupefied's disruption and its DC)." };
            yield return new TextBlock { Id = Guid.Parse("bdfd0880-94ea-4f6a-aba4-8e4cf5f10889"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ Whenever you take a status penalty from the listed conditions, you also take a –1 penalty to the same statistics." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69a4df49-12da-4419-a512-0c4ceccd9cae"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
