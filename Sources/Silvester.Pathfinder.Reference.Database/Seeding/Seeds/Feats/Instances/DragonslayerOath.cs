using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonslayerOath : Template
    {
        public static readonly Guid ID = Guid.Parse("69465049-62f4-4ce3-a0b2-401414307b3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragonslayer Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e99fb45b-b904-4e33-a2fe-53d005ec1205"), Type = TextBlockType.Text, Text = "You’ve sworn to slay evil dragons. Add the following tenet to your code after the others:" };
            yield return new TextBlock { Id = Guid.Parse("b36630e6-c276-4c56-aadb-350c4a7354ee"), Type = TextBlockType.Enumeration, Text = " : You must slay evil dragons you encounter as long as you have a reasonable chance of success." };
            yield return new TextBlock { Id = Guid.Parse("fc9f9bfb-ebc3-4659-9319-718a21c316a0"), Type = TextBlockType.Text, Text = "Your (feat: Retributive Strike) gains a +4 circumstance bonus to damage against an evil dragon, or +6 if you have master proficiency with the weapon you used." };
            yield return new TextBlock { Id = Guid.Parse("0940c7fd-7cba-40cb-a032-bc9452887ef5"), Type = TextBlockType.Text, Text = "Your (feat: Glimpse of Redemption)’s resistance against damage from an evil dragon is 7 + your level." };
            yield return new TextBlock { Id = Guid.Parse("01f8be29-6b75-4e1a-90a9-385145873134"), Type = TextBlockType.Text, Text = "If you use (feat: Liberating Step) triggered by an evil dragon, your ally gains a +4 circumstance bonus to checks granted by your (feat: Liberating Step), and the ally can (action: Step) twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("d4b2e443-d035-4364-ada0-e3ede0618563"), Type = TextBlockType.Text, Text = "You don’t consider evil dragons to be legitimate authorities, even in nations they rule." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("c55d0c9b-a06b-4393-9805-5132c944e598"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9eca8de-c0ca-4407-9839-e26dc4a59b93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
