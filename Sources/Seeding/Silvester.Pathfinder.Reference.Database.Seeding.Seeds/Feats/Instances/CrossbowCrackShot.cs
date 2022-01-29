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
    public class CrossbowCrackShot : Template
    {
        public static readonly Guid ID = Guid.Parse("74e39aa1-b485-49ae-b1ec-0c5e87f97fa4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossbow Crack Shot",
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
            yield return new TextBlock { Id = Guid.Parse("943ba8fe-5ba7-4be9-beb0-4e6ae244f939"), Type = TextBlockType.Text, Text = $"You have a deep understanding of the crossbow. When you're wielding a crossbow and {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload it, including {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions as part of your slinger's reload and similar effects, you gain a +2 circumstance bonus to the damage roll on your next {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with that crossbow. As normal, this isn't cumulative with the +1 circumstance bonus from singular expertise. If the crossbow is a simple crossbow, also increase the damage die size for that attack by one step. You must make the attack before the end of your turn or these benefits are lost." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4df2b6a-2b64-4306-9a4d-f6b14cdb7fa7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
