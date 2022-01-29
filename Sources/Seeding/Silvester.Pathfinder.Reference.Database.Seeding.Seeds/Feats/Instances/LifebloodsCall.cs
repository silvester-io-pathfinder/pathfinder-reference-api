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
    public class LifebloodsCall : Template
    {
        public static readonly Guid ID = Guid.Parse("a7b1754c-d4e7-4a04-93d9-370a61e9e4bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lifeblood's Call",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("718df4fc-02fb-472e-b866-2816724dafa8"), Type = TextBlockType.Text, Text = $"The impulse to survive and continue fighting resonates deep within you. You gain a circumstance bonus to damage rolls on your melee {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} equal to twice the sum of your wounded and doomed conditions (to a maximum of a +8 circumstance bonus to damage) whenever you have one or both conditions." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6de51b71-5a1c-43a8-a0eb-c0acc6dcdd7c"), Traits.Instances.Orc.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7c63740-0981-4ff1-b723-1f05fa31693f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
