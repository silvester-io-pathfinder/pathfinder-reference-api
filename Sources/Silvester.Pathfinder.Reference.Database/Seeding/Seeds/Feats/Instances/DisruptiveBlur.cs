using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptiveBlur : Template
    {
        public static readonly Guid ID = Guid.Parse("188c067a-fad7-4148-937c-dbb63ba32a02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disruptive Blur",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("935c32ee-fe8e-4f18-b323-a7a429b5c523"), Type = TextBlockType.Text, Text = "You use cacophonous blasts from your gun or distracting shots from your crossbow to cause momentary diversions, letting you move about the battlefield with impunity. After you make a (action: Strike) with a firearm or crossbow, creatures can’t take reactions that would be triggered by your movement for the rest of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("c9c2e662-a695-41c4-8673-7f827746191f"), GunslingerWays.Instances.WayOfTheDrifter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8400997d-e5d2-45d2-bf90-bce3422f10ea"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
