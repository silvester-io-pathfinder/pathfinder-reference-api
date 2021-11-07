using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistonPunch : Template
    {
        public static readonly Guid ID = Guid.Parse("70c808a9-605a-40fb-8ad6-70032657f40e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Piston Punch",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e40cfb9-3d8a-4820-b08b-a9cdb1266871"), Type = TextBlockType.Text, Text = "You lash out with a powerful punch, extending your dynamo to a greater length in order to attack two creatures in a row. Make a single bludgeoning or piercing dynamo (action: Strike) and compare the attack roll result to the ACs of up to two foes. The first foe must be within your melee reach and the second foe must be adjacent to the first foe in a straight line away from you. Roll damage only once and apply it to each creature you hit. A Piston Punch counts as two attacks for your multiple attack penalty. Reduce the operational time of your sterling dynamo by 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bea89f8a-6887-4918-85ee-195cc656f2ea"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e6bdb39-2865-4c3c-99c2-470bb3579c82"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
