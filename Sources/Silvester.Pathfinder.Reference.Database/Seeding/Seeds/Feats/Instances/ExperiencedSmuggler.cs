using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExperiencedSmuggler : Template
    {
        public static readonly Guid ID = Guid.Parse("aecfd2bb-d253-426b-86e0-653a92d1f081");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Experienced Smuggler",
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
            yield return new TextBlock { Id = Guid.Parse("8f878711-1400-4722-94c7-afc67370fcf6"), Type = TextBlockType.Text, Text = "You often smuggle things past the authorities. When the GM rolls your Stealth check to see if a passive observer notices a small item you have concealed, the GM uses the number rolled or 10 – whichever is higher – as the result of your die roll, adding it to your Stealth modifier to determine your Stealth check result. If you’re a master in Stealth, the GM uses the number rolled or 15, and if you’re legendary in Stealth, you automatically succeed at hiding a small concealed item from passive observers. This provides no benefits when a creature attempts a Perception check while actively searching you for hidden items. Due to your smuggling skill, you’re more likely to find more lucrative smuggling jobs when using Underworld Lore to (Action: Earn Income)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("06c61d93-2eba-475b-89c7-0fe303689a59"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fff9327f-fddd-4c50-b9c2-b3d17710a8e0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
