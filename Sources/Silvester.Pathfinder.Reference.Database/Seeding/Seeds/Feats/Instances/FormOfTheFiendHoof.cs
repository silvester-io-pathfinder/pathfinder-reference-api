using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheFiendHoof : Template
    {
        public static readonly Guid ID = Guid.Parse("12a38799-4143-4f73-a41c-6268e9946f3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Fiend - Hoof",
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
            yield return new TextBlock { Id = Guid.Parse("64cd2cfd-789d-42b8-bb56-066c6e4ed96a"), Type = TextBlockType.Text, Text = "Part of your body has an obvious, fiendish appearance. You have hooves instead of feet." };
            yield return new TextBlock { Id = Guid.Parse("bb2ad618-d2ec-4da2-b39f-7b30a592487c"), Type = TextBlockType.Enumeration, Text = " Hoof: 1d6 bludgeoning ((trait: finesse), (trait: unarmed))" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b93c84ea-52ee-430e-bca9-d93fc5c39658"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
