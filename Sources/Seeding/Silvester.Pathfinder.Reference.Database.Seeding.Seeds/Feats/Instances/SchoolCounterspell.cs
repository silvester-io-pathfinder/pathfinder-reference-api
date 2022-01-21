using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolCounterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("d5e66738-d597-4b30-93d3-4fff59db8385");

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
            yield return new TextBlock { Id = Guid.Parse("887660ad-d95b-476f-8c4d-0d78f305df3f"), Type = TextBlockType.Text, Text = "Your intricate knowledge of your school lets you easily negate spells from that school. Instead of being able to counter a foe's spell with (feat: Counterspell) only if you have the same spell prepared, if the foe casts a spell from the school matching your specialization, you can (feat: Counterspell) it with any other spell of the same school." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0a8ef390-89d2-4782-aebf-aaf0170ba082"), Feats.Instances.Counterspell.ID);
            builder.HaveSpecificFeat(Guid.Parse("ec325735-4857-4b77-aa7a-baa15de6cfac"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("588bf829-690d-4490-b3b4-ee1b08efe642"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
