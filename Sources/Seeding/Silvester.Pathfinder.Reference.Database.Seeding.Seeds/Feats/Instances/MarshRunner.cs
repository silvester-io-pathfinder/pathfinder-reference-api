using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarshRunner : Template
    {
        public static readonly Guid ID = Guid.Parse("1b208314-47f5-42a2-b461-c2959a0d2c0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marsh Runner",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48f30b1d-9da6-4079-9ef6-d696937f3736"), Type = TextBlockType.Text, Text = "You are adept at moving through marshy terrain. When you use the (Action: Step) action, you can ignore difficult terrain caused by flooding, swamps, or quicksand. In addition, when you use the Acrobatics skill to (Action: Balance) on narrow surfaces or uneven marshy ground, you aren't flat-footed, and if you roll a success on the Acrobatics check, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMovementMethod(Guid.Parse("50eef199-b1de-44e9-8dde-434aa4903722"), MovementMethod.Swimming);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fd2d1ae-5d9c-4e20-8a45-2cfac0e2fd12"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
