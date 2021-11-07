using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BardicLore : Template
    {
        public static readonly Guid ID = Guid.Parse("e669598b-d18e-4fce-a13f-e639fc2b9df7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bardic Lore",
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
            yield return new TextBlock { Id = Guid.Parse("2c8436c7-b0ad-4af2-b936-7ee5f0ff48f0"), Type = TextBlockType.Text, Text = "Your studies make you informed on every subject. You are trained in Bardic Lore, a special Lore skill that can be used only to (action: Recall Knowledge), but on any topic. If you have legendary proficiency in Occultism, you gain expert proficiency in Bardic Lore, but you can’t increase your proficiency rank in Bardic Lore by any other means." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("ccf5f32e-a645-47a1-8a3a-f7b8b94f05eb"), Muses.Instances.Enigma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce44fe00-1ccc-472a-81b1-b5db78ea9faa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
