using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TalismanDabblerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("238476cb-ecd6-4da7-8f5e-a4b485b18382");

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
            yield return new TextBlock { Id = Guid.Parse("9df14c27-ff82-4b39-bf7a-af2d1d689cbf"), Type = TextBlockType.Text, Text = "You are trained in the use of talismans and similar magical paraphernalia. This training might have occurred in a formal classroom or been an agglomeration of folk magic picked up over time. You can craft talismans and know the formulas for all common talismans in the Core Rulebook of your level or lower. You remember talisman formulas and don’t need a formula book for them." };
            yield return new TextBlock { Id = Guid.Parse("37694461-8807-4b25-af4e-8fd280c110eb"), Type = TextBlockType.Text, Text = "Additionally, you carry a collection of magical baubles you can turn into temporary talismans. Each day during your daily preparations, you can make two talismans with an item level no higher than half your level. You must know each talisman’s formula." };
            yield return new TextBlock { Id = Guid.Parse("627a61d4-b9bf-4404-bfd9-448ac3a7f083"), Type = TextBlockType.Text, Text = "A talisman created this way is a temporary item and loses its magic the next time you make your daily preparations if you haven’t already used it." };
            yield return new TextBlock { Id = Guid.Parse("f9b60459-416c-4d0a-874b-cf8ccf95af5b"), Type = TextBlockType.Text, Text = "Finally, when you (action: Affix a Talisman), you can (in any combination) affix or remove up to four talismans in the 10-minute span." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c460f997-d612-4d93-9ffb-11f114f188d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
