using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ViciousDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("d0bab1bd-5dcf-4b29-9e9b-cc900cdcab8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vicious Debilitations",
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
            yield return new TextBlock { Id = Guid.Parse("c1940346-d083-4812-936f-d40ed568438a"), Type = TextBlockType.Text, Text = "The debilitations you dish out seriously impair your foes. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("470cdd5f-c224-48ff-8e50-47d299896489"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target gains weakness 5 to your choice of bludgeoning, piercing, or slashing damage." };
            yield return new TextBlock { Id = Guid.Parse("7f030bfe-4487-49d4-8cc5-925e392a420e"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target becomes clumsy 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("fa4f99a2-0e61-4b14-8bce-3b3527825758"), Rackets.Instances.Ruffian.ID);
            builder.HaveSpecificFeat(Guid.Parse("1e201957-60f6-4eef-84c0-fb372b4ccb76"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("674ea750-0ac3-4c1d-8e06-898dc3dc3622"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
