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
    public class TripleShot : Template
    {
        public static readonly Guid ID = Guid.Parse("a88c12f3-4d58-4937-87ef-196259f9704b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triple Shot",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12cb4fb9-456c-4281-a505-8f48cea5cdb2"), Type = TextBlockType.Text, Text = $"You can quickly fire multiple shots with greater control. When you use {ToMarkdownLink<Models.Entities.Feat>("Double Shot", Feats.Instances.DoubleShot.ID)}, you can make the attacks against the same target. You can add an additional action to {ToMarkdownLink<Models.Entities.Feat>("Double Shot", Feats.Instances.DoubleShot.ID)} to make three ranged {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} instead of two. If you do, the penalty is -4. All attacks count toward your multiple attack penalty, but the penalty doesn't increase until after you've made all of them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("02c90cb8-e43e-4d85-82ea-3d7b6dcaf689"), Feats.Instances.DoubleShot.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b200bebc-7b7e-4b50-8d0e-d8dae8b1d618"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
