using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("0f5dd9d9-162b-45d1-a429-36956b46f1ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Warden",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ddaf076-5416-4bb4-95cf-483a701ea067"), Type = TextBlockType.Text, Text = "When you apply antithetical material against a creature successfully, you also ward yourself against its next attacks. When you (feat: Find Flaws) and succeed at your (action: Recall Knowledge) check, in addition to the normal effects, you gain a +1 status bonus to your AC against the creature’s next attack and a +1 status bonus to your next saving throw against the creature. These bonuses increase to +2 on a critical success. You can gain these bonuses only once per day against a particular creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60123492-a205-4805-bd02-fb1aef07fdcf"), Feats.Instances.FindFlaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99825de3-d5b2-4c64-a339-50a2f84170ab"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
