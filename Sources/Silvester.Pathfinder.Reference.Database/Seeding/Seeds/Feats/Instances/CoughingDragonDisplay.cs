using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoughingDragonDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("b423511c-82a1-440d-8f95-6aac3579d704");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Coughing Dragon Display",
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
            yield return new TextBlock { Id = Guid.Parse("dbf96cfe-f9e9-4692-aa02-254faa52d8fa"), Type = TextBlockType.Text, Text = "This display emits a cascade of loud bangs or glittering trails. While you initially designed the display to captivate your audience’s attention, it turns out to have a surprisingly effective use in combat, suppressing auditory or visual effects behind your magnificent display. You gain the Coughing Dragon fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("dc63cf79-dd9f-4730-b1a6-48cfd1aa5d00"), Type = TextBlockType.Text, Text = "~ Coughing Dragon: TWO-ACTIONS **Cost** 2 batches of infused reagents; **Effect** Choose either (trait: auditory) or (trait: visual) effects. The display gains that trait, and you attempt to counteract one or more effects within 60 feet that have this trait. On a success, the effect is suppressed until the start of your next turn, rather than ending entirely. Use your Fireworks Lore modifier as your counteract modifier, and your counteract level is equal to half your advanced alchemy level (rounded up). A coughing dragon costs 2 batches of infused reagents rather than 1, but you can increase the cost to 3 batches and spend an additional action to create an even bigger coughing dragon display that attempts to counteract both (trait: auditory) and (trait: visual) effects at the same time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ff71f3c0-6be9-4e75-b974-0bbf2917d56c"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb41ec58-e8ae-4128-ab87-f085c9115c65"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
