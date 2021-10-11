using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryPerformerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("12456924-12d6-4f6e-bde1-100892c683b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Performer",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30714efb-c8ad-4874-a32a-a5361cbe1924"), Type = Utilities.Text.TextBlockType.Text, Text = "Your fame has spread throughout the lands. NPCs who succeed at a DC 10 Society check to Recall Knowledge have heard of you and usually have an attitude toward you one step better than normal, depending on your reputation and the NPC’s disposition. For instance, if you’re well-known for cruel and demanding behavior, creatures might be intimidated by you, rather than be friendly toward you. When you Earn Income with Performance, you attract higher-level audiences than your location would allow, as audiences flock to see you. For instance, rulers and angels might travel to your small tower in the woods to hear you perform. Typically, this increases the audiences available by 2 levels or more, determined by the GM." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("4e7be145-127f-4a7c-a9a2-d178e1465cec"), RequiredSkillId = Skills.Instances.Performance.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
            yield return new FeatPrerequisite { Id = Guid.Parse("ccfe054b-4194-4ba2-8bba-4f98b1ed0e4f"), RequiredFeatId = VirtuosicPerformerFeat.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5325d137-18da-489c-ba8c-db06c6952abe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
