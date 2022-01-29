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
    public class SuddenCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("b5f786ec-f619-430a-9326-eb6818ea2bc8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sudden Charge",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd109b14-d0c8-4439-8cbf-94a7e004f964"), Type = TextBlockType.Text, Text = $"With a quick sprint, you dash up to your foe and swing. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} twice. If you end your movement within melee reach of at least one enemy, you can make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against that enemy. You can use Sudden Charge while {ToMarkdownLink<Models.Entities.Action>("Burrowing", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climbing", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Flying", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swimming", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Open.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbf02f49-369c-47ec-866d-6289970287c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
