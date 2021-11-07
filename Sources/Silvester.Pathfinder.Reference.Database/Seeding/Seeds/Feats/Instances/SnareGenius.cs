using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareGenius : Template
    {
        public static readonly Guid ID = Guid.Parse("97b2463b-37a3-49e9-8ad2-b4b6cd7751b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Genius",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0eafd52f-d0db-4a4d-837c-dbdcc092e69f"), Type = TextBlockType.Text, Text = "Your expertise makes your snares more powerful, and you can place them quickly and efficiently. Each day during your daily preparations, you can prepare three snares from your formula book for quick deployment; if the snare normally takes 1 minute to (action: Craft), you can (action: Craft) it with 3 (action: Interact) actions. Snares prepared in this way don&#39;t cost you any resources to (action: Craft). The number of snares you can prepare this way increases to four if you are a master in Crafting, and to five if you are legendary." };
            yield return new TextBlock { Id = Guid.Parse("a5c0cce7-def2-4738-b492-ed8913c17a5c"), Type = TextBlockType.Text, Text = "When you (action: Craft) and deploy a snare that deals damage, any creature that critically fails its saving throw against the snare&#39;s initial effect and takes damage becomes flat-footed until the end of its next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e89c5884-aab1-4cd8-be05-64acdef85fc2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("ccc3b16a-8850-48db-9bbe-b0787459e076"), Feats.Instances.SnareCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2ea38de-bcf0-4ad1-a9bc-2855a96bcfc7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
