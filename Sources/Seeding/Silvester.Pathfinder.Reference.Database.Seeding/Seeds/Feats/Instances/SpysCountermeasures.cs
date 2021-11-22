using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpysCountermeasures : Template
    {
        public static readonly Guid ID = Guid.Parse("cd6d67ab-9d9d-4fc9-a38b-b1cf86a1e530");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spy's Countermeasures",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e33bd1c8-3692-4ea2-92e4-7303f9d8ce64"), Type = TextBlockType.Text, Text = "You've learned how to analyze and fake your responses to the most common magic used against spies. Whenever you succeed at your save against a (trait: divination) or (trait: mental) effect, you can (action: Identify Magic) to identify the spell as a free action triggered when you succeed, even if you didn't notice the spell being cast." };
            yield return new TextBlock { Id = Guid.Parse("10bd4985-25f6-4751-9a9d-e7c5cc48b28c"), Type = TextBlockType.Text, Text = "If you successfully identify a (trait: divination) effect targeting you and the spell would normally fail or have no effect, you can create a substitute result, causing the spell's caster to think the spell succeeded, with a result of your choice." };
            yield return new TextBlock { Id = Guid.Parse("f18c4147-5768-4a35-9686-d1404e3510bb"), Type = TextBlockType.Text, Text = "If you successfully identify a (trait: mental) effect targeting you and the spell would normally fail or have no effect, you can make it appear as if you were affected and attempt to play along with the spell; if the spell normally establishes a mental link, it functions normally but you can disregard any commands you receive through the link." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("526fd172-11a7-4f19-996f-baefeb68e270"), Feats.Instances.LionBladeDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5273ec28-021a-4b75-b994-574d704f7463"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
