using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DenyTheSongsOfWar : Template
    {
        public static readonly Guid ID = Guid.Parse("1a4fc062-c756-477b-abdd-550ff43e3698");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deny the Songs of War",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07b63b25-10c1-48bb-8dfc-c25b1054febd"), Type = TextBlockType.Text, Text = "To keep the peace, you disrupt those who seek to break it. You can cast (spell: deafness) and 4th-level (spell: silence) once per day each as innate spells. The tradition of these spells is the one you chose for the Nantambu Chime-Ringer Dedication feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("82c50a01-222e-4c90-8096-66e872bf34a5"), Feats.Instances.NantambuChimeRingerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("736c5de8-b005-4cfc-a95e-d559e5b5cb91"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
