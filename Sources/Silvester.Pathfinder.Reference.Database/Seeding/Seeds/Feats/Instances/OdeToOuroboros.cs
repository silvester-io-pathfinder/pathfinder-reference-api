using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OdeToOuroboros : Template
    {
        public static readonly Guid ID = Guid.Parse("39ff643f-81fc-40b4-ad66-5619a88cfc35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ode to Ouroboros",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70c9ff1d-f8a6-468f-ba14-d5bd59717829"), Type = TextBlockType.Text, Text = "You learn the (spell: ode to ouroboros) composition spell, which enables you to temporarily spare your allies from death." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ad5bb1f-265f-4d4a-b711-e499cb63fad8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
