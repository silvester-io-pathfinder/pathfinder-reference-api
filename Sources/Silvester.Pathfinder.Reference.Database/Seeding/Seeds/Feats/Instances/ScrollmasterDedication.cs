using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5d29d360-b5f7-46fa-b41e-478e0b121495");

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
            yield return new TextBlock { Id = Guid.Parse("3b0ecf70-6f24-4628-9637-236143cdf33a"), Type = TextBlockType.Text, Text = "Your experience chronicling adventures and discoveries grants you heightened discernment and memory. For 24 hours after learning a prominent fact – such as the name of an NPC you have met, the details of your mission briefing, and similar information – you can recall it without attempting a check, though this doesn’t allow you to automatically memorize long strings of numbers or text. You also gain a +2 circumstance bonus to checks to remember a detail that has come up before in the current adventure, even if it was more than 24 hours ago." };
            yield return new TextBlock { Id = Guid.Parse("1d57cb53-b683-4b88-9158-9a0eee1b0fa5"), Type = TextBlockType.Text, Text = "If you have the (feat: Thorough Reports) feat and have expert proficiency in the skill you’re using to (action: Recall Knowledge), your circumstance bonus to (action: Recall Knowledge) about creatures from that feat increases to +4." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("d4d15f3c-c099-4fb9-ba78-121f428c4ca6"), Proficiencies.Instances.Expert.ID);
            builder.Manual(Guid.Parse("26eb10e4-c253-4237-b924-f556b9cf69e2"), "Member of the Pathfinder Society affiliated with the School of Scrolls.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ca8f999-327b-4317-8c94-e432d2c14a2f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
