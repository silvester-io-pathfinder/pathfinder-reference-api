using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowPact : Template
    {
        public static readonly Guid ID = Guid.Parse("9a763c38-9156-4a8e-b5ad-d3a15706e088");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Pact",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74f96719-910f-43a5-8c81-9047f607371f"), Type = TextBlockType.Text, Text = "~ Access: Nidalese ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("779c14e9-b279-4bbd-a242-29f8739dd800"), Type = TextBlockType.Text, Text = "Thousands of years ago, your ancestors made a pact with Zon-Kuthon. He has not forgotten, even if you might wish he had. You can take 1 damage to mix blood and shadows to cast 5th-level (spell: creation) as an innate divine spell. You can use this ability as often as you wish, but you can have only one such object in existence at a time. If the object encounters bright light, the spell ends and the object dissolves into shadows." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("762d81c8-0176-4bc1-9e9d-dfdde6f02b71"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
