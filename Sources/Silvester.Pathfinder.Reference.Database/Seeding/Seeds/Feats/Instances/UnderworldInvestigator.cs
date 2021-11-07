using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnderworldInvestigator : Template
    {
        public static readonly Guid ID = Guid.Parse("400f20c9-6365-4383-8301-4137003615df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underworld Investigator",
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
            yield return new TextBlock { Id = Guid.Parse("8a55c185-60b5-4268-88a6-94e96bdaf1f7"), Type = TextBlockType.Text, Text = "Your work as an investigator makes you familiar with the criminal element. You might be a criminal yourself, or you might have gained an understanding of how they operate from the outside. You become trained in Underworld Lore, and you gain your (feat: Pursue a Lead) circumstance bonus to Thievery checks to investigate the subject of your lead (such as checks to (action: Steal) a clue from a suspect or (action: Pick a Lock) to open a safe with damning documents)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dedec288-73ae-4f69-8f0a-9caf7b1298b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
