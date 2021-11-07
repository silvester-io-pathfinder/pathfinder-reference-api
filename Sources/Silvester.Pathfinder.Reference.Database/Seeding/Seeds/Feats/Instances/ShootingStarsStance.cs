using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShootingStarsStance : Template
    {
        public static readonly Guid ID = Guid.Parse("9a69dcdb-9104-40f6-8c29-a4f11ed6a328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shooting Stars Stance",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f11950a-9808-4d73-9b2b-203b962b7e9f"), Type = TextBlockType.Text, Text = "You enter a stance that lets you throw shuriken with lightning speed. While in this stance, you can use your monk feats or monk abilities that normally require unarmed attacks with shuriken instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("50b5e24a-090c-47a7-b0f9-ff23744534c2"), Feats.Instances.MonasticWeaponry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("227af7ae-3053-454f-9878-ee8e2bc2b149"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
