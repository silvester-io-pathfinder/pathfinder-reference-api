using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PactOfFeyGlamour : Template
    {
        public static readonly Guid ID = Guid.Parse("b6255ec2-cfb3-49df-bf2b-b0f1a1024811");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pact of Fey Glamour",
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
            yield return new TextBlock { Id = Guid.Parse("24acd7a7-6eaa-4696-bb98-98f4f4aeddfd"), Type = TextBlockType.Text, Text = "You’ve sworn a pact with fey powers, granting you the otherworldly appearance of your dreams in exchange for oaths of hospitality. As long as you keep your end of the bargain, your base appearance changes indefinitely to any one appearance you wish that is within the bounds of possibility for your ancestry; this effect can’t be counteracted or removed except by violating the pact. Additionally, you can cast (spell: illusory disguise) as a primal innate spell once per day, using your thaumaturge class DC instead of your spell DC if you prefer." };
            yield return new TextBlock { Id = Guid.Parse("a48056b7-4601-4087-adc1-c84dac852fbc"), Type = TextBlockType.Text, Text = "In exchange, you promise to accept any fey’s request for hospitality, granting them food, drink, and lodging for up to 3 days and 3 nights. You also promise not to harm any creature to whom you’ve offered hospitality or who has shown hospitality to you, whether or not that creature is fey, unless that creature does harm first. Refusing hospitality to a fey or violating hospitality causes you to lose the benefits of this feat until you atone for your transgressions, instantly reverting your appearance to the one you had before the pact." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec445b31-79df-422d-b5cb-c92f60c2f7e0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
