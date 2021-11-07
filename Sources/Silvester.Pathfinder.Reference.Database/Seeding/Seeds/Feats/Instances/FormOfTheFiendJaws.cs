using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheFiendJaws : Template
    {
        public static readonly Guid ID = Guid.Parse("0c2e2780-e0cb-4660-8860-3c8be6c5d2b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Fiend - Jaws",
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
            yield return new TextBlock { Id = Guid.Parse("fe1060d1-f24f-4270-baec-ec5a24082d7f"), Type = TextBlockType.Text, Text = "Part of your body has an obvious, fiendish appearance. Sharp teeth fill your mouth." };
            yield return new TextBlock { Id = Guid.Parse("e0e69812-f8c7-490c-826d-5383ec1507eb"), Type = TextBlockType.Enumeration, Text = " Jaws: 1d6 piercing ((trait: finesse), (trait: unarmed))" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d504797-f118-4e80-9755-ebe39140c135"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
