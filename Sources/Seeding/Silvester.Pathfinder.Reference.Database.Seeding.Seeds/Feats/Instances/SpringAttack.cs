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
    public class SpringAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("6886ae0f-7202-4b2e-8f79-67e26c481670");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spring Attack",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c30060d2-64a0-4223-8af8-2a4ab105924c"), Type = TextBlockType.Text, Text = $"Springing away from one foe, you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} at another. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed, but you must end that movement within melee reach of a different enemy. At the end of your movement, make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against an enemy now within reach. You can use Spring Attack while {ToMarkdownLink<Models.Entities.Action>("Burrowing", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climbing", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Flying", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swimming", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("768ba0ff-255e-432a-8b68-260783735b20"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
