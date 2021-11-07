using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrowSnatching : Template
    {
        public static readonly Guid ID = Guid.Parse("39636092-dc0b-422f-8dbf-7dba4f885e82");

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
            yield return new TextBlock { Id = Guid.Parse("4dfd96b9-4630-4785-a1e6-908d724be2a3"), Type = TextBlockType.Text, Text = "You pluck missiles from the air and hurl them back at their source. When you successfully deflect an attack with (feat: Deflect Arrow), as part of that reaction, you can immediately make a ranged (action: Strike) against the attacker using the projectile you deflected. This is a (trait: thrown) weapon with the same range increment and effect on a hit as the triggering attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d3f3e322-81f9-4ffb-8123-f37bd952ab44"), Feats.Instances.DeflectArrow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8149f5b1-df99-45a5-95b5-238b084345b7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
