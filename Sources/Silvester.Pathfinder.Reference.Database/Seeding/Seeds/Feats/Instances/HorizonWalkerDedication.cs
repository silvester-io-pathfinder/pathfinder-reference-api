using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HorizonWalkerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("152fdaf8-e3b7-450e-97ba-0e13339cc868");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Horizon Walker Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the horizon walker archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("99be0b7e-ec85-4e67-9239-aac013d4c3ae"), Type = TextBlockType.Text, Text = "You’ve mastered travel within a specific type of terrain. You gain the (feat: Favored Terrain) feat. When in your favored terrain, you gain a +10-foot circumstance bonus to your travel Speed. When other creatures (action: Follow the Expert) with you as a guide in your favored terrain, they gain both the ability to ignore non-magical difficult terrain for the purpose of their travel Speed and the bonus to travel Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5209b564-4167-4655-bfcb-101c75315642"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca7deb92-e4d7-499f-8942-c2dbac98b456"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
