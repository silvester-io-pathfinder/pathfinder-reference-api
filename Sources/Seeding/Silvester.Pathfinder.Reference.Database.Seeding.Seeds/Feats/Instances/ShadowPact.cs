using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowPact : Template
    {
        public static readonly Guid ID = Guid.Parse("29cf9454-e95a-4b7f-abf6-56e655fef438");

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
            yield return new TextBlock { Id = Guid.Parse("8d3e2c15-16f5-4b8d-9a8e-74f5c6d9f882"), Type = TextBlockType.Text, Text = "~ Access: Nidalese ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("f7df7620-8564-41e3-89a4-0b6abbe7e007"), Type = TextBlockType.Text, Text = "Thousands of years ago, your ancestors made a pact with Zon-Kuthon. He has not forgotten, even if you might wish he had. You can take 1 damage to mix blood and shadows to cast 5th-level (spell: creation) as an innate divine spell. You can use this ability as often as you wish, but you can have only one such object in existence at a time. If the object encounters bright light, the spell ends and the object dissolves into shadows." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("489a317b-f514-420c-972f-3fa324921974"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
