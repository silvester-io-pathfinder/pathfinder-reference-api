using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpysCountermeasures : Template
    {
        public static readonly Guid ID = Guid.Parse("3d226ec3-ad60-437d-96ac-d1a97a1a114c");

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
            yield return new TextBlock { Id = Guid.Parse("8fd85ac3-64f2-4f25-b2d5-00a02b4ebe2c"), Type = TextBlockType.Text, Text = "You’ve learned how to analyze and fake your responses to the most common magic used against spies. Whenever you succeed at your save against a (trait: divination) or (trait: mental) effect, you can (action: Identify Magic) to identify the spell as a free action triggered when you succeed, even if you didn’t notice the spell being cast." };
            yield return new TextBlock { Id = Guid.Parse("e965a11c-df4a-435e-8581-7405b40c0fbe"), Type = TextBlockType.Text, Text = "If you successfully identify a (trait: divination) effect targeting you and the spell would normally fail or have no effect, you can create a substitute result, causing the spell’s caster to think the spell succeeded, with a result of your choice." };
            yield return new TextBlock { Id = Guid.Parse("7038948d-8ee3-43a9-af59-bb75f4ef8068"), Type = TextBlockType.Text, Text = "If you successfully identify a (trait: mental) effect targeting you and the spell would normally fail or have no effect, you can make it appear as if you were affected and attempt to play along with the spell; if the spell normally establishes a mental link, it functions normally but you can disregard any commands you receive through the link." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1fc67d15-2602-4751-96fb-0101b25457cb"), Feats.Instances.LionBladeDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("060f2e4b-7a12-48c6-a89d-fe8f03bf1762"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
