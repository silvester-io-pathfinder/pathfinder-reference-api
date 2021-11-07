using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Truespeech : Template
    {
        public static readonly Guid ID = Guid.Parse("5aedf30b-e4a3-437e-8f8d-9987e9be0a7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Truespeech",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fcbdc497-9569-428f-b761-03845277f00f"), Type = TextBlockType.Text, Text = "It is paramount that you are understood and you understand others; language need not impede your message. You can cast (spell: tongues) as a 5th-level divine innate spell once per day on yourself only. You gain a +1 status bonus to Diplomacy checks for the duration of the spell when speaking to creatures with whom you already shared a language before casting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f5a3df7e-9b88-4a48-8a08-6292a505bb39"), Feats.Instances.Angelkin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35365e9f-1d9d-4d1b-a552-437fde5b3db1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
