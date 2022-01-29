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
    public class DisruptiveStance : Template
    {
        public static readonly Guid ID = Guid.Parse("3cf51bf2-76bf-4908-99e6-305b621b3188");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disruptive Stance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b38785a4-c791-4a1c-8577-7963f2be0606"), Type = TextBlockType.Text, Text = $"The slightest distraction can provoke your wrath, and you're prepared to foil enemies' actions. As long as you are in this stance, you can use {ToMarkdownLink<Models.Entities.Feat>("Attack of Opportunity", Feats.Instances.AttackOfOpportunity.ID)} when a creature within your reach uses a {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} action, in addition to {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} and {ToMarkdownLink<Models.Entities.Trait>("move", Traits.Instances.Move.ID)} actions. Furthermore, you disrupt a triggering {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} or {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} action if your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits (not only if it's a critical hit)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daf4e280-08fa-41da-a3c0-de29acbf0521"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
