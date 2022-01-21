using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChargedCreation : Template
    {
        public static readonly Guid ID = Guid.Parse("1ed41639-fbc5-46dd-b187-4e493ec1ea3b");

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
            yield return new TextBlock { Id = Guid.Parse("ef8c7486-ccab-45c3-ae66-594d1098d36d"), Type = TextBlockType.Text, Text = $"Your magic is drawn to your persistent creations. While you are within 30 feet of and have line of effect to your persistent creation, you can use it as the origin point for your line or cone spells. For instance, a {ToMarkdownLink<Models.Entities.Spell>("lightning bolt", Spells.Instances.LightningBolt.ID)} could originate from the persistent creation rather than from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2fe902fb-1bfa-4c39-9182-bdead42b5762"), Feats.Instances.PersistentCreation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4969756-ff2b-48b5-a5be-4ad634d22325"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
