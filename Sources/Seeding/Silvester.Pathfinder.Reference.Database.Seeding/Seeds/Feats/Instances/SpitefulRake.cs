using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpitefulRake : Template
    {
        public static readonly Guid ID = Guid.Parse("7d009916-431b-413c-9eef-967907c9412f");

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
            yield return new TextBlock { Id = Guid.Parse("0e0bb07d-d523-4249-9734-14d05e7462a5"), Type = TextBlockType.Text, Text = "Your instincts sing of spite and malice, and you’ve learned a devastating trick: go for the eyes. You make a claw (action: Strike). If you hit and deal damage, the target is dazzled for 1 round. On a critical hit, the target is instead blinded for 1 round and dazzled until restored to maximum hit points." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("5fc48ecb-3c1c-44c3-9b1a-f1dec2c9a318"), UnarmedWeapons.Instances.Claws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40ca5e8b-a1e6-4ddd-9815-ab631f8876d0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
