using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlankSlate : Template
    {
        public static readonly Guid ID = Guid.Parse("97bf3f63-4ccd-40dd-90c0-f329addc2848");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blank Slate",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98ff29fe-9d6a-44a5-879f-dd35d7ecb6c1"), Type = TextBlockType.Text, Text = "Your deceptions confound even the most powerful mortal divinations. (trait: Detection), (trait: revelation), and (trait: scrying) effects pass right over you, your possessions, and your auras, detecting nothing unless the detecting effect has a counteract level of 10 or higher. For example, (spell: detect magic) would still detect other magic in the area but not any magic on you, (spell: true seeing) wouldn’t reveal you, locate or scrying wouldn’t find you, and so on." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b6aecf5e-9351-4f47-af26-0625b9f808cd"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac3c6da9-b64e-44e9-9ba6-9bb1da80e305"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
