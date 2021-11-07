using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ZephyrGuardDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c352db4a-7255-4ef8-8cff-ffe96e244baa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Zephyr Guard Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Zephyr Guard archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ece0133a-022f-48af-b9f8-ee0f2ae1917b"), Type = TextBlockType.Text, Text = "~ Access: You are from Katapesh." };
            yield return new TextBlock { Id = Guid.Parse("b90b532d-02fd-48a9-a6d6-66239e3b8e73"), Type = TextBlockType.Text, Text = "As a Zephyr Guard, you’re always vigilant against crime and threats to the city’s safety. You gain a +1 circumstance bonus to Perception checks against attempts to (action: Palm an Object), (action: Steal), or (action: Conceal an Object) (including if you’re (action: Seeking | Seek) concealed objects). You become trained in Society and Katapesh Lore; if you were already trained, you become an expert instead." };
            yield return new TextBlock { Id = Guid.Parse("f6c08659-0424-4035-a5d8-d759648d44d4"), Type = TextBlockType.Text, Text = "__(If you are already trained in Society or Katapesh Lore, override the proficiency on your character sheet.)__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("bc5b09f5-9bf9-43a4-ab54-125a3c5cb115"), "Member of the Zephyr Guard");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bd801f0-9bcc-40e3-8725-0d62a38968d8"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
