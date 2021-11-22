using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoughingDragonDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("c2590c9f-63f1-4fa8-bd89-1cf449618811");

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
            yield return new TextBlock { Id = Guid.Parse("cf0c5fbf-4510-4d76-95f4-379bc8aaa457"), Type = TextBlockType.Text, Text = "This display emits a cascade of loud bangs or glittering trails. While you initially designed the display to captivate your audience's attention, it turns out to have a surprisingly effective use in combat, suppressing auditory or visual effects behind your magnificent display. You gain the Coughing Dragon fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("6353925f-2874-46ab-86c0-cef40aea4bef"), Type = TextBlockType.Text, Text = "~ Coughing Dragon: TWO-ACTIONS **Cost** 2 batches of infused reagents; **Effect** Choose either (trait: auditory) or (trait: visual) effects. The display gains that trait, and you attempt to counteract one or more effects within 60 feet that have this trait. On a success, the effect is suppressed until the start of your next turn, rather than ending entirely. Use your Fireworks Lore modifier as your counteract modifier, and your counteract level is equal to half your advanced alchemy level (rounded up). A coughing dragon costs 2 batches of infused reagents rather than 1, but you can increase the cost to 3 batches and spend an additional action to create an even bigger coughing dragon display that attempts to counteract both (trait: auditory) and (trait: visual) effects at the same time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f416d595-32c7-4a2b-9815-ef94a421f549"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("856f1031-76ab-49d4-84fc-137200a3dee2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
