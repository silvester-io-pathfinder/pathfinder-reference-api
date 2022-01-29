using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuillSpray : Template
    {
        public static readonly Guid ID = Guid.Parse("a7ca34e9-7503-48a6-b029-f93ac5e3016d");

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
            yield return new TextBlock { Id = Guid.Parse("76055b45-c88a-4829-a2d9-774b30e98cad"), Type = TextBlockType.Text, Text = $"You can launch a mass of quills at opponents. You spray quills in a 30-foot cone, dealing 5d8 piercing damage. Each creature in the area must attempt a basic saving throw against the higher of your class DC or spell DC. On a critical failure, a creature also takes 5 persistent bleed damage. At 11th level and every even level thereafter, the piercing damage increases by 1d8 and the persistent bleed damage increases by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("40807f7a-771d-4b80-bf03-e67b8eadae13"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("bc927ed0-85b7-44e6-8ad0-3eee97c62bab"), Heritages.Instances.QuillcoatShisk.ID);
                or.HaveSpecificUnarmedAttack(Guid.Parse("b54a5709-b2ec-463b-8bf2-6eac6cad9dfc"), UnarmedWeapons.Instances.Quill.ID);
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
                Id = Guid.Parse("002c377b-979d-40b7-8902-6b70864f341b"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
