using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicBloodlineSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("f6f79e98-f6d7-4a7b-89e7-e94e11877156");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Bloodline Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a3271ad-a67d-4766-9136-aac2b6db82e8"), Type = TextBlockType.Text, Text = "You gain your bloodline’s initial bloodline spell. If you don’t already have one, you also gain a focus pool of 1 Focus Point, which you can (action: Refocus) without any special effort. (For more on bloodline spells, see page 194.)" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9564c484-a2a7-41be-b3fa-b43a90ef20a2"), Feats.Instances.SorcererDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91b6747c-1106-4910-98da-710a97e124b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
