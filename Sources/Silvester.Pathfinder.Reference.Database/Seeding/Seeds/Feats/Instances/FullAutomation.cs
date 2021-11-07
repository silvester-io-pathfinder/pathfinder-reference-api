using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FullAutomation : Template
    {
        public static readonly Guid ID = Guid.Parse("7c1cdcdc-dc46-4ffb-bb86-243bd697163d");

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
            yield return new TextBlock { Id = Guid.Parse("b2f28438-8a3e-47cb-a1ec-5860481d1eaa"), Type = TextBlockType.Text, Text = "You become so entwined with your innovations that you can use them without a second thought. You’re permanently quickened. How you can use the extra action depends on your innovation." };
            yield return new TextBlock { Id = Guid.Parse("e6af64ab-69fc-413f-8d6b-2f31732b3a01"), Type = TextBlockType.Enumeration, Text = " Armor: Your armor responds to the most subtle stimuli to move you in the right direction as long as you are wearing it. You can use the extra action to (action: Stride), (action: Step), or use a form of movement provided by your innovation (such as (action: Fly) or (action: Swim))." };
            yield return new TextBlock { Id = Guid.Parse("ba21d3f8-993a-4f80-903c-3595f061c4f2"), Type = TextBlockType.Enumeration, Text = " Construct: Your ability to command your construct becomes instinctive. You can use the extra action to Command your construct innovation (or to provide 1 of the actions if you choose to spend 2 actions to Command your construct)." };
            yield return new TextBlock { Id = Guid.Parse("d3afce9c-09c8-4ddb-a720-3f725096803f"), Type = TextBlockType.Enumeration, Text = " Weapon: Your weapon becomes easier to wield with deadly efficacy, almost as if it is an extension of your body. It speeds effortlessly toward whatever target you choose as long as you are holding it. You can use the extra action to (action: Strike) with your innovation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("29917c1d-edfe-464a-81c8-da334c455929"), or => 
            {
                or.HaveSpecificInnovation(Guid.Parse("302a1829-25c5-41f3-9c58-7f4f7c0274e6"), Innovations.Instances.Armor.ID);
                or.HaveSpecificInnovation(Guid.Parse("be1f1b95-668e-4792-941b-9d28b59f4f34"), Innovations.Instances.Construct.ID);
                or.HaveSpecificInnovation(Guid.Parse("7647b38a-2bca-466b-baef-87089190c331"), Innovations.Instances.Weapon.ID);
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
                Id = Guid.Parse("e38d20f7-6ab1-406f-b7a1-04985354334d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
