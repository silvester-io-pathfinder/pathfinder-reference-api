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
    public class OverlookedMastermind : Template
    {
        public static readonly Guid ID = Guid.Parse("8d3ccf61-ece5-4ef4-ac4f-1eb20e5ef0e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overlooked Mastermind",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c74182ec-854f-4ffa-bb51-4eb3e22b30d3"), Type = TextBlockType.Text, Text = $"Many consider half-orcs little more than dumb brutes. This is offensive to you, but it can occasionally be useful. You are trained in Deception (or another skill of your choice if you were already trained in Deception), and you gain a +2 circumstance bonus to Deception checks to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} when specifically claiming ignorance and to Deception DCs against {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} checks to uncover such lies." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.HalfOrc.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63f79264-00a1-4202-8119-a90ebdd7709e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
