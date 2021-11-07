using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2a3a9f06-f7b9-41b2-9563-5cf402785af7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scrollmaster Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Scrollmaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a3d004e-3f76-4f9b-adeb-b4c00d259c65"), Type = TextBlockType.Text, Text = "Your experience chronicling adventures and discoveries grants you heightened discernment and memory. For 24 hours after learning a prominent fact – such as the name of an NPC you have met, the details of your mission briefing, and similar information – you can recall it without attempting a check, though this doesn’t allow you to automatically memorize long strings of numbers or text. You also gain a +2 circumstance bonus to checks to remember a detail that has come up before in the current adventure, even if it was more than 24 hours ago." };
            yield return new TextBlock { Id = Guid.Parse("fee8408b-1ff7-4a0b-8a52-915aa687c56e"), Type = TextBlockType.Text, Text = "If you have the (feat: Thorough Reports) feat and have expert proficiency in the skill you’re using to (action: Recall Knowledge), your circumstance bonus to (action: Recall Knowledge) about creatures from that feat increases to +4." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("fe3fbdeb-3ca5-49f5-b519-508f06a94f6c"), Proficiencies.Instances.Expert.ID);
            builder.Manual(Guid.Parse("d63ade15-9ca8-4ff7-90c2-e9ddf672bc00"), "Member of the Pathfinder Society affiliated with the School of Scrolls.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3dd7dcdf-4cd9-46a7-b1d5-c567b874d1f9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
