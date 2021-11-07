using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InitialEidolonAbility : Template
    {
        public static readonly Guid ID = Guid.Parse("2c5f102e-93c1-4dbc-a7f8-e3529bbcd65c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Initial Eidolon Ability",
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
            yield return new TextBlock { Id = Guid.Parse("957b3540-c31b-4236-bb23-8791d191e6e0"), Type = TextBlockType.Text, Text = "Your link to your eidolon becomes stronger, granting it a new ability. Your eidolon gains the initial ability for an eidolon of its type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("061fe415-22d5-4c45-a45f-49f47891270b"), Feats.Instances.SummonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1027749-bd4a-447f-8089-b0369c3d813b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
