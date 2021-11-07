using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerfulShove : Template
    {
        public static readonly Guid ID = Guid.Parse("6634c36a-bbd3-4567-8fe7-8c6283d5b764");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Powerful Shove",
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
            yield return new TextBlock { Id = Guid.Parse("21e20f4b-3972-4f33-a3e0-512e058055bc"), Type = TextBlockType.Text, Text = "You can push larger foes around with your attack. You can use (Feat: Aggressive Block) or (Feat: Brutish Shove) against a creature up to two sizes larger than you." };
            yield return new TextBlock { Id = Guid.Parse("b5f0254c-b004-4846-bd0e-e88318318df6"), Type = TextBlockType.Text, Text = "When a creature you (Action: Shove) has to stop moving because it would hit an object, it takes damage equal to your Strength modifier (minimum 1). This happens regardless of how you (Action: Shoved | Shove) the creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("ef5e6d71-27a9-4222-ad95-0f50713aebdd"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("2f20b72c-4b2e-49b3-a02f-ad8eab22f513"), Feats.Instances.AggressiveBlock.ID);
                or.HaveSpecificFeat(Guid.Parse("22919489-ec38-448c-b9e6-0a729cd14f81"), Feats.Instances.BrutishShove.ID);
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
                Id = Guid.Parse("d6d08fc2-a3a1-4ba7-a5d1-5fb95afdebb0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
