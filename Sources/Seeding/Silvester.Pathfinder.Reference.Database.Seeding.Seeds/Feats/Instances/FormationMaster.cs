using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormationMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("eef6ea2b-39f9-4af5-9f12-eb3d1259067f");

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
            yield return new TextBlock { Id = Guid.Parse("865ee541-6040-4242-ae49-c32ff91ae16f"), Type = TextBlockType.Text, Text = "You can assemble a formation even with members of ancestries that lack the hobgoblins' military discipline, and you can extend these benefits to your hobgoblin allies. When you are adjacent to at least two humanoid allies, you gain the benefits of (Feat: Formation Training), even if they aren't hobgoblin allies. Hobgoblin allies adjacent to you and at least one other hobgoblin ally also gain the bonuses from your (Feat: Formation Training) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ccc52bd1-1ec1-468f-97c1-474b8a256476"), Feats.Instances.FormationTraining.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee1494ff-58cb-49fc-ae98-351c1e6122a4"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
