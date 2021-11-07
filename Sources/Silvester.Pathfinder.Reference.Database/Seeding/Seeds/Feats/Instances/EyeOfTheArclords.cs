using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeOfTheArclords : Template
    {
        public static readonly Guid ID = Guid.Parse("ec1a460a-154a-4177-9785-2f19ddcefca3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye of the Arclords",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3822aa89-8fe3-406f-a5bd-8532c14c6889"), Type = TextBlockType.Text, Text = "~ Access: You are a member of the Arclords of Nex." };
            yield return new TextBlock { Id = Guid.Parse("6c3b90da-f849-4514-8588-d82c9f278c85"), Type = TextBlockType.Text, Text = "You open an incandescent third eye upon your forehead. The eye can remain open for 1 minute, and you can close it before then with a single action with the (trait: concentrate) trait. It can remain open for 2 minutes if you’re a master in Arcana, or 5 minutes if you’re legendary." };
            yield return new TextBlock { Id = Guid.Parse("6d1fa461-61be-4df0-90a8-a0f34909a2bf"), Type = TextBlockType.Text, Text = "While the eye is open, you gain the following benefits: you gain the effects of the (spell: detect magic) arcane innate spell from your (feat: Arcane Sense) at the start of each of your turns without needing to cast the spell; you gain darkvision; you gain a +2 status bonus to Perception checks to (action: Seek) undetected and hidden creatures and to your Perception DC against (action: Hide) and (action: Sneak). After your third eye closes, you are dazzled for an amount of time equal to how long you had it open." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("34efdbb4-eae9-490e-8d46-70d648632ce2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
            builder.HaveSpecificFeat(Guid.Parse("fc309b56-a855-48d6-bd2b-2b7ddc681143"), Feats.Instances.ArcaneSense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d1d35aa-5dfc-418c-a981-c671b726d86f"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
