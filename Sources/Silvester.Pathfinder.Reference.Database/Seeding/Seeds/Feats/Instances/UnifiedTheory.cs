using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnifiedTheory : Template
    {
        public static readonly Guid ID = Guid.Parse("b257c3ee-8f50-4ea6-b696-13f1fa509922");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unified Theory",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("720e1594-e2a3-4bce-849c-bc509cdb5165"), Type = TextBlockType.Text, Text = "You’ve started to make a meaningful connection about the common underpinnings of the four traditions of magic and magical essences, allowing you to understand them all through an arcane lens. Whenever you use a skill action or a skill feat that requires a Nature, Occultism, or Religion check, depending on the magic tradition, you can use Arcana instead. If you would normally take a penalty or have a higher DC for using Arcana on other magic (such as when using (action: Identify Magic)), you no longer do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ebd402b7-b7c4-48be-8fa4-39f204aba97b"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce4fdb3a-bf64-4355-b89f-830e302eae73"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
