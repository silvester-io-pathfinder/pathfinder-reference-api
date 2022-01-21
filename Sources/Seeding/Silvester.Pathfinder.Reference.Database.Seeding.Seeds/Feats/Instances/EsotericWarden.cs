using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("2e2600cb-45be-4a56-b4ef-d0612cfba48d");

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
            yield return new TextBlock { Id = Guid.Parse("3267b59e-3cb5-45d3-aa9c-dfca12426cd5"), Type = TextBlockType.Text, Text = "When you apply antithetical material against a creature successfully, you also ward yourself against its next attacks. When you (feat: Find Flaws) and succeed at your (action: Recall Knowledge) check, in addition to the normal effects, you gain a +1 status bonus to your AC against the creature's next attack and a +1 status bonus to your next saving throw against the creature. These bonuses increase to +2 on a critical success. You can gain these bonuses only once per day against a particular creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f9cecadb-5366-4bff-b708-8ee43eff61c7"), Feats.Instances.FindFlaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("584b4a44-242d-4762-84e0-4e39638d38fe"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
