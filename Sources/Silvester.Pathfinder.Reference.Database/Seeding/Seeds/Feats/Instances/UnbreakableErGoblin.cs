using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbreakableErGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("ea43a5fa-7b0f-45fb-80ec-af106bc92afe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbreakable-er Goblin",
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
            yield return new TextBlock { Id = Guid.Parse("a2703810-39fd-4d95-99b0-55f4e17cf03e"), Type = TextBlockType.Text, Text = "As hard as most unbreakable goblins are to break, you are that much harder to break. You gain 20 Hit Points from your ancestry instead of 10. When you fall, you take no falling damage. If you have the (feat: Bouncy Goblin) feat, after falling or jumping from a height of at least 20 feet, you can bounce back into the air, up to half the distance you fell (and half as far forward if you jumped). These bounces continue until you bounce less than 20 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("4d9f6c66-10a7-4221-a99f-f4990ad0a86d"), Heritages.Instances.UnbreakableGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3be42ee-9f71-4394-b116-51617e147caa"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
