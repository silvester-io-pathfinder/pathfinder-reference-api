using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuillSpray : Template
    {
        public static readonly Guid ID = Guid.Parse("63424ada-60a7-4dd8-9fa0-63662d725f86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quill Spray",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8768015f-aa7a-4d33-b346-b9ae46c31410"), Type = TextBlockType.Text, Text = "You can launch a mass of quills at opponents. You spray quills in a 30-foot cone, dealing 5d8 piercing damage. Each creature in the area must attempt a basic saving throw against the higher of your class DC or spell DC. On a critical failure, a creature also takes 5 persistent bleed damage. At 11th level and every even level thereafter, the piercing damage increases by 1d8 and the persistent bleed damage increases by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d51da896-50ec-4b70-b920-0048b36f56f6"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("2a9de53d-f7c9-40e2-b339-a4ebb733ce3f"), Heritages.Instances.QuillcoatShisk.ID);
                or.HaveSpecificUnarmedAttack(Guid.Parse("56c52934-6320-4d0f-b039-3b09bebced5b"), UnarmedAttack.Quill);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75757767-1da7-4251-a36d-e2ab1e743d30"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
