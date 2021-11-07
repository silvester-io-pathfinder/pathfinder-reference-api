using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpitefulRake : Template
    {
        public static readonly Guid ID = Guid.Parse("922699ef-1d37-41cb-a49f-e8a431c4b766");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiteful Rake",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a48655af-1655-42eb-a702-eaeaf05cfa98"), Type = TextBlockType.Text, Text = "Your instincts sing of spite and malice, and you’ve learned a devastating trick: go for the eyes. You make a claw (action: Strike). If you hit and deal damage, the target is dazzled for 1 round. On a critical hit, the target is instead blinded for 1 round and dazzled until restored to maximum hit points." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("d1c1f072-8b9d-4cc0-adda-52780f4eda1b"), UnarmedAttack.Claws);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("510379ac-390c-4708-8578-9d04ff5b5728"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
