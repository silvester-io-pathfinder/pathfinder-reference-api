using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("d4abae1f-046a-4fd0-8128-9faf547f0369");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heal Companion",
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
            yield return new TextBlock { Id = Guid.Parse("d0ffd80c-4c83-484c-bf72-013bdc42496f"), Type = TextBlockType.Text, Text = "You have a deep devotion to your animal companion that enables you to magically heal their wounds. You gain the (spell: heal companion) warden spell and a focus pool of 1 Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyAnimalCompanion(Guid.Parse("66b5d76f-9896-4532-a5a6-c12500eff944"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86ad0641-33fe-47c9-97a1-32c8500b8e6a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
