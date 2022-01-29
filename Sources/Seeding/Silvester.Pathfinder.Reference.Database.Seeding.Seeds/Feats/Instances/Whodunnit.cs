using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Whodunnit : Template
    {
        public static readonly Guid ID = Guid.Parse("0b963b43-5f2b-4457-8283-94c5d0b37507");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whodunnit?",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d77c08c1-5aa6-4417-a479-b8ce84581ad8"), Type = TextBlockType.Text, Text = $"You carefully consider your case and narrow down some of the details. When you {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)}, you can spend 10 minutes instead of 1 minute to ask two questions of the GM as you complete the activity. The GM must answer truthfully with “yes” or “no,” though if the answer would be misleading or have no practical application to your investigation the GM can answer “immaterial.” You can't use Who Dunnit- more than once for the same lead, even across different days." };
            yield return new TextBlock { Id = Guid.Parse("a70120cd-bede-495f-bff1-43c443a94e3f"), Type = TextBlockType.Text, Text = $"Your questions must come from the following list, applying to either the creature or the clue you found:" };
            yield return new TextBlock { Id = Guid.Parse("a328a2ed-eb44-4aa0-a11a-d64f3b3c32e3"), Type = TextBlockType.Enumeration, Text = $" : Was the clue left by a [creature trait]- (Choose a creature trait such as humanoid, undead, or dwarf; this trait must be accurate as of the time the clue was left.)" };
            yield return new TextBlock { Id = Guid.Parse("a5409a01-9338-4dcc-a58c-c7e1f3dc1d52"), Type = TextBlockType.Enumeration, Text = $" : Was this clue left within the last hour-" };
            yield return new TextBlock { Id = Guid.Parse("02d71079-39c8-4635-aaf3-e7aa328ff5db"), Type = TextBlockType.Enumeration, Text = $" : Was this clue left within the last day-" };
            yield return new TextBlock { Id = Guid.Parse("b01c2e03-5554-40cb-a307-2f5c2d301982"), Type = TextBlockType.Enumeration, Text = $" : Was the creature that left the clue in a heightened emotional state when it left the clue-" };
            yield return new TextBlock { Id = Guid.Parse("f2dfcfa1-cd89-4366-a0d0-4b1762d4685e"), Type = TextBlockType.Enumeration, Text = $" : Did the creature attempt to conceal this clue-" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef019bdc-d0f6-4cf9-a033-3a066c775236"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
