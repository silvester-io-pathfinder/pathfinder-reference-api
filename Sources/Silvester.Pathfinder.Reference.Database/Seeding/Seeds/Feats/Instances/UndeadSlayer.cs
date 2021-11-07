using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UndeadSlayer : Template
    {
        public static readonly Guid ID = Guid.Parse("5e051467-0a65-4f6c-b698-843f3148ead4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undead Slayer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f28e6f3-6f4f-4a99-a16d-3869eb6625f2"), Type = TextBlockType.Text, Text = "Your knowledge of your own not-quite-living anatomy, combined with your experience in combat, helps you take down undead foes with ease. Against undead creatures, you gain a circumstance bonus to damage with weapons and unarmed attacks equal to the number of weapon damage dice for the (action: Strike). This bonus increases to double the number of weapon damage dice if your target has the (trait: vampire) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f03e9aa9-744a-4f6b-b537-c27357d6840b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
