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
    public class TangleOfBattle : Template
    {
        public static readonly Guid ID = Guid.Parse("5ec5711c-5fde-4b10-83b8-b56866b2dbb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tangle of Battle",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically hit an adjacent enemy.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fe433d0-d610-4d08-8692-10d225c3c4ba"), Type = TextBlockType.Text, Text = $"Your incredibly vicious {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} pulls you right in close, giving you the opportunity to grab your foe. Attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)} the triggering enemy." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3f001ed5-7aca-4b56-883c-bcd68c3c2890"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("8e8fdc10-4364-4bd9-bc44-d230d0d585a9"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ea167fe-f076-4024-ae12-4c98ad94baf8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
