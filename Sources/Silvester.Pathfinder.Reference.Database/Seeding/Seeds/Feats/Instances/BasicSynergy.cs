using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("d0b7892a-a050-4c3d-8115-f188eba89717");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Synergy",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfdf9c59-a1d1-4c53-a26f-65729fd6509d"), Type = TextBlockType.Text, Text = "You gain a 1st- or 2nd-level summoner feat of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ab8db3be-21ec-44bc-a6a4-05ead6126ccb"), Feats.Instances.SummonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d4611cf-a5d8-49c6-aac0-c66edfcf5b0c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
