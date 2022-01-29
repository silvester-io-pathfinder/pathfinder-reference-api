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
    public class Shorthanded : Template
    {
        public static readonly Guid ID = Guid.Parse("200fdbfc-f2b4-4f3c-9ce8-dc7679ff2bd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shorthanded",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f764b1a-f68c-4b40-acda-4f994ec1a404"), Type = TextBlockType.Text, Text = $"Typically, a siege weapon is meant to be run by a crew with a very specific minimum number of members designed to ensure that your crew can account for every possible variable and necessity in loading, aiming, and firing the weapon. In a pinch, however, you can operate it with fewer people, provided you know what you're doing. You can operate a siege weapon with fewer than the minimum number of crew, at an increasing penalty. You and your crew take a –2 penalty to checks to Load, Aim, Launch, move, or Repair the weapon for each person below the minimum crew. The maximum number of missing minimum crew members you can handle with this feat is 5. For example, if a siege weapon had a minimum crew size of 8, you would still need a crew of 3, and you would take a –10 penalty when doing so." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9dd2056c-df88-4302-a5b2-922b066e8cfe"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
