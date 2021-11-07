using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Whodunnit : Template
    {
        public static readonly Guid ID = Guid.Parse("94952581-df74-480a-aee6-26f8c701bd2d");

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
            yield return new TextBlock { Id = Guid.Parse("34a00939-c791-46ca-9ba6-cd0ea3c31790"), Type = TextBlockType.Text, Text = "You carefully consider your case and narrow down some of the details. When you (feat: Pursue a Lead), you can spend 10 minutes instead of 1 minute to ask two questions of the GM as you complete the activity. The GM must answer truthfully with “yes” or “no,” though if the answer would be misleading or have no practical application to your investigation the GM can answer “immaterial.” You can&#39;t use Who Dunnit- more than once for the same lead, even across different days." };
            yield return new TextBlock { Id = Guid.Parse("d4727f49-ac36-4037-a088-735110c9a732"), Type = TextBlockType.Text, Text = "Your questions must come from the following list, applying to either the creature or the clue you found:" };
            yield return new TextBlock { Id = Guid.Parse("d7eae540-91b0-4c9c-a3d7-02fb96031369"), Type = TextBlockType.Enumeration, Text = " : Was the clue left by a [creature trait]- (Choose a creature trait such as humanoid, undead, or dwarf; this trait must be accurate as of the time the clue was left.)" };
            yield return new TextBlock { Id = Guid.Parse("ecd1041a-58f9-401f-833d-069fb280f8a5"), Type = TextBlockType.Enumeration, Text = " : Was this clue left within the last hour-" };
            yield return new TextBlock { Id = Guid.Parse("c5e0c7c7-be50-455d-8f6f-ce6e97e806c1"), Type = TextBlockType.Enumeration, Text = " : Was this clue left within the last day-" };
            yield return new TextBlock { Id = Guid.Parse("fed51de3-1658-4c9f-a930-b876c028bd06"), Type = TextBlockType.Enumeration, Text = " : Was the creature that left the clue in a heightened emotional state when it left the clue-" };
            yield return new TextBlock { Id = Guid.Parse("b152c41f-19fa-4c66-892c-77c3fc3a358c"), Type = TextBlockType.Enumeration, Text = " : Did the creature attempt to conceal this clue-" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24cbd18d-8547-4922-a003-827efdfc97a0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
