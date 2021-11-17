using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FullAutomation : Template
    {
        public static readonly Guid ID = Guid.Parse("d595f7c3-b6a0-4d11-82ea-5b1b2a46b4e8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Full Automation",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8623db83-9f3d-4e7a-97c5-b80e51ed2e6e"), Type = TextBlockType.Text, Text = "You become so entwined with your innovations that you can use them without a second thought. You’re permanently quickened. How you can use the extra action depends on your innovation." };
            yield return new TextBlock { Id = Guid.Parse("c448fbd5-5d19-4389-8731-abb8e85d83ff"), Type = TextBlockType.Enumeration, Text = " Armor: Your armor responds to the most subtle stimuli to move you in the right direction as long as you are wearing it. You can use the extra action to (action: Stride), (action: Step), or use a form of movement provided by your innovation (such as (action: Fly) or (action: Swim))." };
            yield return new TextBlock { Id = Guid.Parse("798c5b00-1252-447e-a786-8f705228534e"), Type = TextBlockType.Enumeration, Text = " Construct: Your ability to command your construct becomes instinctive. You can use the extra action to Command your construct innovation (or to provide 1 of the actions if you choose to spend 2 actions to Command your construct)." };
            yield return new TextBlock { Id = Guid.Parse("206475e5-cf49-4a67-800f-2cd4597d7beb"), Type = TextBlockType.Enumeration, Text = " Weapon: Your weapon becomes easier to wield with deadly efficacy, almost as if it is an extension of your body. It speeds effortlessly toward whatever target you choose as long as you are holding it. You can use the extra action to (action: Strike) with your innovation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b529876e-e6ee-4e3b-8414-3b1c6dedd0a2"), or => 
            {
                or.HaveSpecificInnovation(Guid.Parse("d4c66af0-a39b-4981-94cc-5866820a7614"), Innovations.Instances.Armor.ID);
                or.HaveSpecificInnovation(Guid.Parse("8559e97f-13d1-4dd0-9e04-35ad3a5efd45"), Innovations.Instances.Construct.ID);
                or.HaveSpecificInnovation(Guid.Parse("adb02162-4b23-4d44-8676-d1e284d0c7e2"), Innovations.Instances.Weapon.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0035e22-c89c-4383-b446-f92429574d89"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
