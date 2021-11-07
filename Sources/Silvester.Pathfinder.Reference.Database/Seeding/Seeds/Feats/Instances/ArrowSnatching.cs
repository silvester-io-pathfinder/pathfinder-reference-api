using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrowSnatching : Template
    {
        public static readonly Guid ID = Guid.Parse("4dbd105c-8328-48a9-8a88-a28fb4efa6c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arrow Snatching",
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
            yield return new TextBlock { Id = Guid.Parse("2d05d347-5a13-4c33-a073-8692443add6c"), Type = TextBlockType.Text, Text = "You pluck missiles from the air and hurl them back at their source. When you successfully deflect an attack with (feat: Deflect Arrow), as part of that reaction, you can immediately make a ranged (action: Strike) against the attacker using the projectile you deflected. This is a (trait: thrown) weapon with the same range increment and effect on a hit as the triggering attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc39ec9f-ce0d-4ef3-a274-0bcfd4576cf9"), Feats.Instances.DeflectArrow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a2fb51b-fd33-4480-9278-f1ec79ee7434"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
