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
    public class GroupAid : Template
    {
        public static readonly Guid ID = Guid.Parse("850875c0-4d30-4eb3-85b8-ffd5c52b9763");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Group Aid",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08ce85fd-e69d-4112-9a2c-57012e69cd89"), Type = TextBlockType.Text, Text = $"Your upbringing emphasized teamwork and helping your allies comes naturally to you. After you {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} an ally at a skill check that doesn't have the {ToMarkdownLink<Models.Entities.Trait>("attack", Traits.Instances.Attack.ID)} trait, you can also {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} any other ally who attempts the same skill check for the same purpose that round. You do so as a free action rather than a reaction." };
            yield return new TextBlock { Id = Guid.Parse("70da21c2-aa82-49db-8a2a-e1202fec8ed6"), Type = TextBlockType.Text, Text = $"The preparation you did to help must still apply to the other allies, and you can {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} each ally only once. For example, if you helped lift up an ally to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} them on an Athletics check to scale a wall, you could keep the same posture to give a boost to other allies attempting to scale the wall in the same round." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("780439dd-3630-41a8-83aa-e7743eb3ee77"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8759ee7-7d2d-4bec-a2c4-dee4aa5a8b11"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
