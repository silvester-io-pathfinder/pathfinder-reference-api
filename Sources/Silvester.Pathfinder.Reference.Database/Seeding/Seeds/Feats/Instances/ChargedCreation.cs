using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChargedCreation : Template
    {
        public static readonly Guid ID = Guid.Parse("64fae1dc-9cf3-4069-9601-e36dc243b4e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charged Creation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cc062d8-dfed-4de4-afe1-22c8f94880fc"), Type = TextBlockType.Text, Text = "Your magic is drawn to your persistent creations. While you are within 30 feet of and have line of effect to your persistent creation, you can use it as the origin point for your line or cone spells. For instance, a (spell: lightning bolt) could originate from the persistent creation rather than from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e373aac-0f84-47d8-b867-99d451da14d5"), Feats.Instances.PersistentCreation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d29c4ec-ec9b-4b71-b209-624fd9a3ba8a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
