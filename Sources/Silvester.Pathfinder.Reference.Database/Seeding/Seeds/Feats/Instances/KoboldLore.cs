using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KoboldLore : Template
    {
        public static readonly Guid ID = Guid.Parse("c0821a58-6394-4cb8-b2bd-afcec2b79c0c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kobold Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49f1b835-b33c-402e-902e-eb60d0cfb3d4"), Type = TextBlockType.Text, Text = "You attentively learned key kobold survival strategies and mythology from your elders. You gain the trained proficiency rank in Stealth and Thievery. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Kobold Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("779fc7e2-ef8c-4ba7-a7ed-f8465531ba6b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
