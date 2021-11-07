using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProtectAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("cc82427c-2b8f-42b2-8166-dcefeeb65f48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Protect Ally",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce0f75cb-a7fc-4f86-acee-f8ef916d484a"), Type = TextBlockType.Text, Text = "You place your body between your friends and your enemies, protecting your allies against oncoming attacks. You choose one adjacent ally. That ally gains a +1 circumstance bonus to AC until the start of your next turn or until that ally is no longer adjacent to you, whichever comes first. You can only protect a single ally in this way. If you choose to Protect a different Ally, the previous ally loses the bonus to AC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8657b228-3018-4b4c-ad62-027cc07f25fa"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be172353-c0d4-47a2-bdf0-0b0fb221d94d"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
