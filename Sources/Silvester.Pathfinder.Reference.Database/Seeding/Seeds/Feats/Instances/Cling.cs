using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cling : Template
    {
        public static readonly Guid ID = Guid.Parse("084963b4-3ccf-4bd8-a336-010a996bb33c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cling",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this action without a free hand if your preceding Strike was made with your jaws or a similar unarmed attack you could use to hang on. The GM determines which unarmed attacks apply. Hanging on in this way prevents you from using that unarmed attack.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("534e880b-b5d4-4516-a3fa-99dfbf2d5fe8"), Type = TextBlockType.Text, Text = "You hang onto a foe to harry them into submission. If your target moves while you’re hanging onto it, you can choose to move with the target. The target is released if you choose not to move with it, at the start of your next turn, or if the target (action: Escapes | Escape). Attempts to (action: Escape) from a Cling follow the rules for (action: Escape), but use your Acrobatics DC and end the Cling instead of the conditions normally ended by the (action: Escape) action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5b8d2fa-b4aa-4c9a-8813-4a361563b131"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
