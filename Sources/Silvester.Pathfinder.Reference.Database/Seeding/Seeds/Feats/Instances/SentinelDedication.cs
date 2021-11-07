using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SentinelDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5173c7a8-d30e-4cf9-aed0-8046c2ad5ec7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sentinel Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the sentinel archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b3b76b9-da74-4c94-94be-74c9a577b884"), Type = TextBlockType.Text, Text = "You have trained carefully to maximize the protective qualities of your armor. You become trained in light armor and medium armor. If you already were trained in light armor and medium armor, you gain training in heavy armor as well. Whenever you gain a class feature that grants you expert or greater proficiency in any type of armor (but not unarmored defense), you also gain that proficiency in the armor types granted to you by this feat. If you are at least 13th level and you have a class feature that grants you expert proficiency in unarmored defense, you also become an expert in the armor types granted to you by this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("106e43ee-5f7e-4d87-9783-9f792536e0bc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
