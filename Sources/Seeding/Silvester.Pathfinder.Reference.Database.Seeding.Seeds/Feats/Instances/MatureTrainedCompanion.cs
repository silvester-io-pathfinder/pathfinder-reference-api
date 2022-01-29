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
    public class MatureTrainedCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("483fa3fe-3738-4008-99a4-e331b3834430");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mature Trained Companion",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d008786-a9ec-4ef2-b64b-28cd08cf0d62"), Type = TextBlockType.Text, Text = $"Your animal companion grows up, becoming a mature animal companion. Increase its proficiency rank in Performance to expert instead of one of the three skill increases for mature. It gains the {ToMarkdownLink<Models.Entities.Feat>("Mesmerizing Performance", Feats.Instances.MesmerizingPerformance.ID)} advanced maneuver, rather than the normal advanced maneuver for its type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a4c476a1-3f2b-44e1-b470-d90f0231d076"), Feats.Instances.AnimalTrainerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4240530c-f4d8-4b16-ab00-d7d5bcf8646b"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
