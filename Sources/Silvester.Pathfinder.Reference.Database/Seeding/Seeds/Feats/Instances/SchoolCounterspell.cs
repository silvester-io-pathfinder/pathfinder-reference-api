using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolCounterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("f4eabb46-c1c2-41cc-9622-33368744d873");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School Counterspell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1ac0c22-c4d3-47f7-b314-2457de2c0b7a"), Type = TextBlockType.Text, Text = "Your intricate knowledge of your school lets you easily negate spells from that school. Instead of being able to counter a foe’s spell with (feat: Counterspell) only if you have the same spell prepared, if the foe casts a spell from the school matching your specialization, you can (feat: Counterspell) it with any other spell of the same school." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5abd21ac-203a-4cc9-8362-734d5b350d24"), Feats.Instances.Counterspell.ID);
            builder.HaveSpecificFeat(Guid.Parse("343b8ba3-2798-42de-823f-eaaee4216268"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea170847-dab4-462e-bb01-1c7ff272713f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
