using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallOfTheWild : Template
    {
        public static readonly Guid ID = Guid.Parse("c1ba884c-c08c-430c-b46d-9b3fbbf3fa24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call of the Wild",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b3dbd84-5cf8-4757-9329-2e8be3ffa507"), Type = TextBlockType.Text, Text = $"You call upon the creatures of nature to come to your aid. You can spend 10 minutes in concert with nature to replace one of the spells you've prepared in one of your druid spell slots with a {ToMarkdownLink<Models.Entities.Spell>("summon animal", Spells.Instances.SummonAnimal.ID)} or {ToMarkdownLink<Models.Entities.Spell>("summon plant or fungus", Spells.Instances.SummonPlantOrFungus.ID)} spell of the same level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8edcdbb3-89a8-4fc9-aad7-66f1bab1e34a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
