using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmorSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("0f19c192-ca5f-4f82-9678-d9aa6239050f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Specialist",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5eb8e7f-4303-4c1e-a291-ee38ee4c6091"), Type = TextBlockType.Text, Text = "You have trained hard to optimize your armor’s protective qualities. You gain the armor specialization effects of medium and heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fd51c13b-4ebc-4b59-9fb6-0160f9dd7065"), Feats.Instances.SentinelDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0d9deac-62be-46e7-beac-141bc58ddc79"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
