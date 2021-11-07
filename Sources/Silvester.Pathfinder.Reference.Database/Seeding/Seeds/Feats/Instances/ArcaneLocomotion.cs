using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneLocomotion : Template
    {
        public static readonly Guid ID = Guid.Parse("349f55b8-ecfb-48bf-8f4b-89adab677648");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Locomotion",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("117095fd-1cd0-4c1f-85f6-ee9cb5531253"), Type = TextBlockType.Text, Text = "You’ve modified your body to allow you to augment your movement. You gain either a climb Speed of 20 feet or a swim Speed of 20 feet, your choice." };
            yield return new TextBlock { Id = Guid.Parse("80146428-f52a-4947-b9b1-6b460393451e"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("d2c68da2-60c0-420c-b4c4-aa83a8103b3d"), Type = TextBlockType.Text, Text = "~ Enhancement: Your body allows for even further forms of movement. You can either select the option from this feat you haven’t chosen yet (climb Speed or swim Speed), or you can increase your land Speed by 5 feet and increase the Speed you chose from this feat increase to be equal to your adjusted land Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38a8afa4-0194-4b50-b2f4-e9a966880eef"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
