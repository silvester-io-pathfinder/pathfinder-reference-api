using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class FlatFooted : Template
    {
        public static readonly Guid ID = Guid.Parse("72287426-a2d9-4d8b-8b2a-9a696baa3f1d");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Flat-Footed",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1d864f8-5b68-4c68-b26a-b615fcddef91"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re distracted or otherwise unable to focus your full attention on defense. You take a –2 circumstance penalty to AC. Some effects give you the flat-footed condition only to certain creatures or against certain attacks. Others— especially conditions—can make you universally flatfooted against everything. If a rule doesn’t specify that the condition applies only to certain circumstances, it applies to all of them; for example, many effects simply say “The target is flat-footed.”" };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f6ef9b5-9e0d-4ae7-9a3a-de2709f94003"),
                SourceId = CoreRulebook.ID,
                Page = 620
            };
        }
    }
}
