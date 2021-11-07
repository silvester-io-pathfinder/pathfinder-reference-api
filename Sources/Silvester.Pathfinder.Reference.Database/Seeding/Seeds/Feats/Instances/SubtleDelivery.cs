using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SubtleDelivery : Template
    {
        public static readonly Guid ID = Guid.Parse("54646fa3-c060-4226-bb07-81bd1f0e6ca9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Delivery",
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
            yield return new TextBlock { Id = Guid.Parse("421cf2f4-461b-4671-b96b-6528e862f3a1"), Type = TextBlockType.Text, Text = "You can capably deliver toxins with a blowgun. Your (item: blowgun) (action: Strikes | Strike) can apply (trait: injury) poisons even if they deal no damage due to a creature’s resistance. If you critically succeed at an attack roll using a (item: blowgun) loaded with a dart you’ve poisoned and the target rolls a failure on the poison’s initial save, the target critically fails instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b3de993-b45d-46a0-9e79-88e1f13207f1"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3555cdb-5954-4c93-9e11-55ba96991699"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
