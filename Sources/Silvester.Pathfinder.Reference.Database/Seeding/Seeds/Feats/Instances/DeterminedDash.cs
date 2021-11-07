using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeterminedDash : Template
    {
        public static readonly Guid ID = Guid.Parse("cf8766f5-59f9-42cc-8e63-6d4cad93c92f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Determined Dash",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1b7ee7b-3d4a-4690-b334-bc24dfd0df08"), Type = TextBlockType.Text, Text = "Nothing can keep you from your enemy. (action: Stride) twice. During this movement you ignore difficult terrain, greater difficult terrain, and any effects that would impose a penalty to Speed. You can attempt an Athletics check instead of an Acrobatics check to (action: Balance) when moving across narrow surfaces or uneven ground, using the same DC. This doesn&#39;t prevent you from being harmed by hazardous terrain. You can increase the number of actions this activity takes to 3 to (action: Stride) three times instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3aab5682-4d76-4167-8a43-4ebc2f8a0eae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
