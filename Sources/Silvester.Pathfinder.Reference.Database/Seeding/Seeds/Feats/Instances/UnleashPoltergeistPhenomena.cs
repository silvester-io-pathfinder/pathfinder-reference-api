using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashPoltergeistPhenomena : Template
    {
        public static readonly Guid ID = Guid.Parse("e0561579-d997-4b52-ba51-f60e0410892b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Poltergeist Phenomena",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b163ff7b-ceff-4117-99fb-7c2a3a8eca28"), Type = TextBlockType.Text, Text = "When your mind is unleashed, so is your sense of control, spilling psychic energies forth in an indiscriminate maelstrom." };
            yield return new TextBlock { Id = Guid.Parse("6f8d76c2-c2c1-4edd-8c53-17ee91e7d52e"), Type = TextBlockType.Text, Text = "~ Benefit: While this psyche is Unleashed, you gain an aura of telekinetically whirling debris in a 15-foot emanation. Any creature that starts its turn in the aura takes 1d4 damage for every 2 levels you have, with a basic Reflex save against your spell DC. The damage is generally bludgeoning, piercing, or slashing damage based on the environment (for example, slashing damage if used near a glass window, bludgeoning damage if used in a cobblestone street). The GM might decide that other types of damage are applicable in rarer environments." };
            yield return new TextBlock { Id = Guid.Parse("5bb759d8-423c-4017-aebb-6b5457e078fa"), Type = TextBlockType.Text, Text = "~ Drawback: You aren’t immune to the chaos of your power. You must be included in the aura of this psyche and must save against it as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3929348b-6355-4d39-a50e-d770ebfea35a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
