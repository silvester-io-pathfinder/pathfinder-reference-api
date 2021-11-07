using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HagClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("591e9f69-c151-4461-a50f-87806e9afbbf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hag Claws",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "claws can develop at any point in a changeling's life, allowing you to select this feat anytime you would gain an ancestry feat, but once you've selected it, you can't retrain out of it.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8b03c57-2d0d-425a-a421-a884e9808a62"), Type = TextBlockType.Text, Text = "When you came of age, your fingernails grew long and sharp. You gain a claw unarmed attack that deals 1d4 slashing damage. Your claws are in the brawling group and have the (trait: agile), (trait: finesse), and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d61a772-e0df-42e0-b9f4-23828a8fc303"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
