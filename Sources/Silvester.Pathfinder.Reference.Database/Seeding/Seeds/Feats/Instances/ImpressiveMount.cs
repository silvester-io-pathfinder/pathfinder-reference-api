using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpressiveMount : Template
    {
        public static readonly Guid ID = Guid.Parse("03291887-4396-4dde-a0ac-0b377ee03561");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impressive Mount",
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
            yield return new TextBlock { Id = Guid.Parse("9d586290-fbbe-4e64-a3da-3892007191a9"), Type = TextBlockType.Text, Text = "You’ve trained your mount to become a powerful force on the battlefield. The mount you gained through the (feat: Cavalier Dedication) feat becomes a mature animal companion, granting it additional capabilities. During an encounter, even if you don’t use the (action: Command an Animal) action, your animal companion can still use 1 action on your turn to (action: Stride) or (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("65f7eb7f-b6ca-4ae6-9a1f-2c3295dd8f17"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51630cf3-f42b-4bf0-a9f7-c04f20c6f655"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
