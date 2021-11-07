using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueShapeshifter : Template
    {
        public static readonly Guid ID = Guid.Parse("b0d1d9fb-f964-4024-a4ea-41e104dac96d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Shapeshifter",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f8125b3-c5c8-46fe-970b-55408654d027"), Type = TextBlockType.Text, Text = "You transcend the limitations of form. While under the effects of (Spell: wild shape), you can change into any other form on your (Spell: wild shape) list; if the durations of the forms would vary, use the shorter of the two durations." };
            yield return new TextBlock { Id = Guid.Parse("0551b523-5462-4376-a047-946e6d8c625a"), Type = TextBlockType.Text, Text = "Once per day, you can transform into a kaiju, with the effects of (Spell: nature incarnate); if you have (Feat: Plant Shape), you can instead transform into a green man." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b08a8029-4b2c-49ee-9ad5-bd629d37175e"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb09b6a4-deb3-4f03-9afe-f398c671da43"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
