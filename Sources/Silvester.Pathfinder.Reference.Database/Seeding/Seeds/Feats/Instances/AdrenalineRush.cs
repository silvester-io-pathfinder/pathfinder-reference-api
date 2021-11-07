using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdrenalineRush : Template
    {
        public static readonly Guid ID = Guid.Parse("1304a1da-9b32-4cb0-bda0-3c7a851a7ef8");

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
            yield return new TextBlock { Id = Guid.Parse("c32644dd-e588-4434-8358-595c0caee589"), Type = TextBlockType.Text, Text = "In the heat of battle, you are capable of amazing feats of strength. While you are raging, increase your encumbered and maximum Bulk limits by 2; you also gain a +1 status bonus to Athletics checks to lift heavy objects, (action: Escape), and (action: Force Open)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9efd2cfb-bf18-435e-a3a5-89cab625b70b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
