using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TalismanDabblerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("a3b1c405-01a8-4dd0-854f-c460a88b52e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Talisman Dabbler Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the talisman dabbler archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c833ed8-7a79-4573-aef9-2577bb4e4f0c"), Type = TextBlockType.Text, Text = "You are trained in the use of talismans and similar magical paraphernalia. This training might have occurred in a formal classroom or been an agglomeration of folk magic picked up over time. You can craft talismans and know the formulas for all common talismans in the Core Rulebook of your level or lower. You remember talisman formulas and don’t need a formula book for them." };
            yield return new TextBlock { Id = Guid.Parse("ee6bd2f8-81f7-4d3d-933e-0ff4ff82b34b"), Type = TextBlockType.Text, Text = "Additionally, you carry a collection of magical baubles you can turn into temporary talismans. Each day during your daily preparations, you can make two talismans with an item level no higher than half your level. You must know each talisman’s formula." };
            yield return new TextBlock { Id = Guid.Parse("c2ee2ec4-6976-4f61-bc06-e0f2ad5515e6"), Type = TextBlockType.Text, Text = "A talisman created this way is a temporary item and loses its magic the next time you make your daily preparations if you haven’t already used it." };
            yield return new TextBlock { Id = Guid.Parse("fa385ce6-bd61-4266-8c81-09859b8f590b"), Type = TextBlockType.Text, Text = "Finally, when you (action: Affix a Talisman), you can (in any combination) affix or remove up to four talismans in the 10-minute span." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ccc708e-63ba-4984-906c-d3f601768245"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
