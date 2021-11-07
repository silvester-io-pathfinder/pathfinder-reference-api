using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AccurateFlurry : Template
    {
        public static readonly Guid ID = Guid.Parse("346a5b9f-b4a8-4673-9639-93fe96ff6969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accurate Flurry",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cec476da-4fc2-426a-a802-74b30053d46e"), Type = TextBlockType.Text, Text = "You refine the precision of your unbelievable storm of blows. When you perform an (feat: Impossible Flurry), your first attack with each weapon instead takes the multiple attack penalty as though you had already made one attack this turn. All subsequent attacks take the maximum multiple attack penalty, as though you had already made two or more attacks this turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("abd6e599-5ea8-44e7-8e6c-820365f8ec26"), Feats.Instances.ImpossibleFlurry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61592faf-69c7-40ed-813b-8a18451b0d2b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
