using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickStudy : Template
    {
        public static readonly Guid ID = Guid.Parse("c0deb8a6-77fd-4607-a9b2-582f902c8e09");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Study",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e602d68-b4d7-4c66-bf6f-9193ca891079"), Type = TextBlockType.Text, Text = "During your daily preparations, you can study a particular subject to gain the trained proficiency rank in one Lore skill of your choice. You must have interacted with that subject in some way on the previous day, whether by reading about it, talking to someone knowledgeable on the topic, or experiencing it yourself. Alternatively, you can reference your notes to instead choose a Lore skill you’ve prepared before with Quick Study. This proficiency lasts until you prepare again. Since this proficiency is temporary, you can’t use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("89bcfcc8-82ee-47ae-88b1-5e9ef0885e8d"), Feats.Instances.LoremasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57ebb9dd-60ed-47a4-a2b2-261d4de83c6a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
