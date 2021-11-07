using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TigerStance : Template
    {
        public static readonly Guid ID = Guid.Parse("53cd2c01-0616-471c-9c17-694c0f35a95e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tiger Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("defa6a6a-eb08-4996-b86b-9178621eedd3"), Type = TextBlockType.Text, Text = "You enter the stance of a tiger and can make tiger claw attacks. These deal 1d8 slashing damage; are in the brawling group; and have the (trait: agile), (trait: finesse), (trait: nonlethal), and (trait: unarmed) traits. On a critical success with your tiger claws, if you deal damage, the target takes 1d4 persistent bleed damage." };
            yield return new TextBlock { Id = Guid.Parse("6dd34fa3-c867-4d65-a530-b78013cf9ada"), Type = TextBlockType.Text, Text = "As long as your Speed is at least 20 feet while in Tiger Stance, you can (action: Step) 10 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3ec2d4dc-4b71-4b47-8d69-413dd83604ec"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24abc1c5-41c7-43f0-ae64-3714e235d49f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
