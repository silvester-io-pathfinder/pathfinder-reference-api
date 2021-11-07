using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdrenalineRush : Template
    {
        public static readonly Guid ID = Guid.Parse("1b2c739b-de5a-40da-85dd-3e4a72272e72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adrenaline Rush",
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
            yield return new TextBlock { Id = Guid.Parse("8df50df9-595b-4dbc-9b5e-197d8060dda9"), Type = TextBlockType.Text, Text = "In the heat of battle, you are capable of amazing feats of strength. While you are raging, increase your encumbered and maximum Bulk limits by 2; you also gain a +1 status bonus to Athletics checks to lift heavy objects, (action: Escape), and (action: Force Open)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81827f92-ae8d-4628-a3b3-691883b09f31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
