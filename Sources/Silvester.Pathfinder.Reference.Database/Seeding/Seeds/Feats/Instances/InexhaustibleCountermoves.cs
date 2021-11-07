using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InexhaustibleCountermoves : Template
    {
        public static readonly Guid ID = Guid.Parse("b8920ba8-3d1a-4c1a-a107-8e42ff9cfa92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inexhaustible Countermoves",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f6d4744-46da-4a18-8097-15bc47953902"), Type = TextBlockType.Text, Text = "You can react whenever a foe leaves a gap in their defenses. At the start of each enemy’s turn, you gain an extra reaction you can use only during that turn to perform an (feat: Opportune Riposte), or an (feat: Attack of Opportunity) if you have that reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fafb781-f6e6-47ca-b702-1f165830edfa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
