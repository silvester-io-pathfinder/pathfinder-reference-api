using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormationMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("27c607cb-eb87-4491-a1c1-51268a5fcc98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Formation Master",
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
            yield return new TextBlock { Id = Guid.Parse("855017bc-25c9-4cc3-8133-c5fe17df0a8f"), Type = TextBlockType.Text, Text = "You can assemble a formation even with members of ancestries that lack the hobgoblins’ military discipline, and you can extend these benefits to your hobgoblin allies. When you are adjacent to at least two humanoid allies, you gain the benefits of (Feat: Formation Training), even if they aren’t hobgoblin allies. Hobgoblin allies adjacent to you and at least one other hobgoblin ally also gain the bonuses from your (Feat: Formation Training) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("860eea95-4fb8-4fd1-9bea-c0360f795840"), Feats.Instances.FormationTraining.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba56e9eb-4580-4b96-b186-2c938c9aec5a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
