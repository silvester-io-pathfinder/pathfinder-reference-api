using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemonbloodFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("a65acbc3-4095-41b9-8748-99c05cd886ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demonblood frenzy",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully Strike a living creature that has the fiend trait with your tusks unarmed attack.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45cb094a-5683-414f-b133-9c16c617224a"), Type = TextBlockType.Text, Text = "Just the taste of fiendish blood is enough to send blood rushing through your veins in a supernatural fury. You become quickened until the end of your next turn and you can use the extra action to make a tusks (action: Strike), (action: Stride), or (action: Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("b0142a6b-5c41-48dd-87be-9fc73d9e1706"), UnarmedAttack.Tusks);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44c4ce2f-ac7c-409f-832b-1f0d25f9f075"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
