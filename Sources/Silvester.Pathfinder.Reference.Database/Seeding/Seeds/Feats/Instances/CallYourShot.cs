using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallYourShot : Template
    {
        public static readonly Guid ID = Guid.Parse("b26e9893-e888-48a5-8b63-b4d370c513c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Your Shot",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffb366b9-a78a-4ed2-916d-1791a8eace85"), Type = TextBlockType.Text, Text = "When you successfully (feat: Play to the Crowd), add the following to the list of benefits you can choose from:" };
            yield return new TextBlock { Id = Guid.Parse("8041ec41-4043-4766-80d9-4277fafe2434"), Type = TextBlockType.Enumeration, Text = " : Choose a creature within 30 feet that can see you to become frightened 1. This effect has the (trait: emotion), (trait: fear), (trait: mental), and (trait: visual) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4d6f599b-ca37-4226-bb88-14502c2eb6fa"), Feats.Instances.PlayToTheCrowd.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb19e376-db4c-403b-9b64-566752e3eb8e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
