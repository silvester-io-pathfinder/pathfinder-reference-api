using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdditionalLore : Template
    {
        public static readonly Guid ID = Guid.Parse("338b25c8-b868-4e8b-8ccb-5cbe56b347c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you must select a new subcategory of Lore and you gain the additional skill increases to that subcategory for the listed levels.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ff3ca7a-ac7a-4167-8f24-89845b881239"), Type = TextBlockType.Text, Text = "Your knowledge has expanded to encompass a new field. Choose an additional Lore skill subcategory. You become trained in it. At 3rd, 7th, and 15th levels, you gain an additional skill increase you can apply only to the chosen Lore subcategory." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4a28e0d-b136-4af5-8dd0-89f67cdb3b47"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
