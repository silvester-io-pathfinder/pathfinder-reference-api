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
    public class ReturningThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("7f323e1c-ceaa-4b63-b24d-963dda6c8ba3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Returning Throw",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc65b112-19ba-4eac-a85c-292257da1641"), Type = TextBlockType.Text, Text = $"You have mastered the technique of arcing a projectile so that it returns to your hand after being thrown, though this requires a moment to precisely calculate the trajectory and possible ricochets. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a thrown weapon. Once the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is complete, the weapon arcs or ricochets back to your hand. If your hands are full when the weapon returns, it falls to the ground in your space." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1a1109f9-4a2b-4876-8c0c-b074f3046782"), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55cf7cfd-d944-420b-8eaa-095965f655b8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
