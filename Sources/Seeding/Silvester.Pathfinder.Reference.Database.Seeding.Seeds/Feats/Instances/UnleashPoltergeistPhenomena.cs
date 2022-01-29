using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashPoltergeistPhenomena : Template
    {
        public static readonly Guid ID = Guid.Parse("3c368b1a-aaf6-4c28-9517-3db37e71d2ca");

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
            yield return new TextBlock { Id = Guid.Parse("f9815bcb-4525-40b5-b4bc-1c0b3a25aeb6"), Type = TextBlockType.Text, Text = $"When your mind is unleashed, so is your sense of control, spilling psychic energies forth in an indiscriminate maelstrom." };
            yield return new TextBlock { Id = Guid.Parse("04dbbd86-ca44-4bb0-81a1-e512b85a256d"), Type = TextBlockType.Text, Text = $"~ Benefit: While this psyche is Unleashed, you gain an aura of telekinetically whirling debris in a 15-foot emanation. Any creature that starts its turn in the aura takes 1d4 damage for every 2 levels you have, with a basic Reflex save against your spell DC. The damage is generally bludgeoning, piercing, or slashing damage based on the environment (for example, slashing damage if used near a glass window, bludgeoning damage if used in a cobblestone street). The GM might decide that other types of damage are applicable in rarer environments." };
            yield return new TextBlock { Id = Guid.Parse("3b3c79fe-0d0d-4285-a80f-4f98a4ab8c83"), Type = TextBlockType.Text, Text = $"~ Drawback: You aren't immune to the chaos of your power. You must be included in the aura of this psyche and must save against it as normal." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9adcf3d-42db-4c50-8f74-5dc452d4b4f9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
